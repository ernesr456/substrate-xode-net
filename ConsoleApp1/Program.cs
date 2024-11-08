using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Substrate.Xode.NetApiExt.Generated;
using Substrate.Xode.NetApiExt.Generated.Model.frame_system;
using Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.NetApi;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using static Substrate.NetApi.Mnemonic;
using System.Security.Cryptography;
using Substrate.NET.Schnorrkel.Keys;
using Substrate.Xode.NetApiExt.Generated.Model.sp_runtime.multiaddress;
using Substrate.Xode.NetApiExt.Generated.Storage;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialize logging (optional)
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        // Connect to the client
        var client = new SubstrateClientExt(
            new Uri("wss://rpcnodea01.xode.net/n7yoxCmcIrCF6VziCcDmYTwL8R03a/ws"),
            ChargeTransactionPayment.Default());

        await client.ConnectAsync();

        // Check if the client is connected
        if (client.IsConnected)
        {
            Console.WriteLine("Successfully connected to the network.");

            // Generate AccountId
            var accountId = new AccountId32();
            accountId.Create(Utils.GetPublicKeyFrom("5E527tSWccd9VPDGAtCBKVvvBJhbTUqsMHcmXogRhzZD8YwY"));

            // Log accountId
            Console.WriteLine($"AccountId: {accountId}");

            // Fetch the account balance
            var accountBalance = await client.SystemStorage.Account(accountId, null, CancellationToken.None);
            double assetBalance = accountBalance != null ? (double)accountBalance.Data.Free.Value / Math.Pow(10, 12) : 0;  // For plancks (10^10)

            // Log the account balance
            Console.WriteLine($"Account balance: {assetBalance:0.00} XON");

            // Generate random mnemonic
            var random = RandomNumberGenerator.Create(); // Cryptographically secure RNG
            var entropyBytes = new byte[16];
            random.GetBytes(entropyBytes);
            string mnemonics = string.Join(" ", Mnemonic.MnemonicFromEntropy(entropyBytes, BIP39Wordlist.English));

            // Log the generated mnemonic
            Console.WriteLine($"Generated Mnemonic: {mnemonics}");

            // Account password (used for deriving the secret key)
            string password = "Rioalma1";
            ExpandMode expandMode = ExpandMode.Ed25519; // Currently preferred in Substrate

            var secret = Mnemonic.GetSecretKeyFromMnemonic(mnemonics, password, BIP39Wordlist.English);
            var miniSecret = new MiniSecret(secret, expandMode);

            // Build the actual Account for signing
            Account account = Account.Build(
                KeyType.Sr25519,
                miniSecret.ExpandToSecret().ToBytes(),
                miniSecret.GetPair().Public.Key);

            // Log the account public key
            Console.WriteLine($"Account Public Key: {account}");

            // Create MultiAddress for transfer
            var multiAddress = new EnumMultiAddress();
            multiAddress.Create(0, accountId);

            // Log MultiAddress
            Console.WriteLine($"MultiAddress: {multiAddress}");

            // Define the transfer amount (equivalent to 1 XON)
            var amount = new BaseCom<U128>(1000000000000); // Equivalent to 1 XON (10^12 Plancks)
            Console.WriteLine($"Transfer Amount: {amount.Value}");

            // Build the transfer method
            Method transfer = BalancesCalls.TransferKeepAlive(multiAddress, amount);

            // Determine the charge type
            ChargeType charge = ChargeTransactionPayment.Default();

            // Transaction lifetime (64 blocks)
            uint lifeTime = 64;

            // Log the transfer method
            Console.WriteLine($"Transfer Method: {transfer}");

            // Submit the extrinsic (transaction)
            try
            {
                await client.Author.SubmitExtrinsicAsync(transfer, account, charge, lifeTime, CancellationToken.None);
                Console.WriteLine("Transaction submitted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting transaction: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Failed to connect to the network.");
        }
    }
}
