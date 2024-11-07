using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Substrate.Integration.Client;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Rpc;
using Substrate.NetApi.Model.Types;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialize logging (optional)
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        // Initialize the BaseClient with the WebSocket URL for the Xode chain
        string networkUrl = "wss://rpcnodea01.xode.net/n7yoxCmcIrCF6VziCcDmYTwL8R03a/ws";
        var baseClient = new BaseClient(networkUrl);

        // Define a CancellationToken (to handle cancellation of async operations)
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        // Connect to the network
        bool isConnected = await baseClient.ConnectAsync(useMetadata: true, standardSubstrate: true, token);
        if (isConnected)
        {
            Console.WriteLine("Successfully connected to the network!");

            // Example of generating an extrinsic (replace with your actual method)
            var extrinsicType = "tx"; // Replace with a real type
                                                        // Convert string to byte arrays
            byte moduleIndex = (byte)"Balance"; // 'B' for "Balance"
            byte callIndex = (byte)"transfer";   // 't' for "transfer"

            // Construct the Method object with byte arguments
            var extrinsicMethod = new Method(8, 1, new byte[] { /* parameters here */ });

            int concurrentTasks = 5; // Adjust as needed

            var account = BaseClient.Alice; // Using the predefined Alice account

            string subscriptionId = await baseClient.GenericExtrinsicAsync(account, extrinsicType, extrinsicMethod, concurrentTasks, token);
            if (subscriptionId != null)
            {
                Console.WriteLine($"Extrinsic sent successfully with subscription ID: {subscriptionId}");
            }

            // Example of subscribing to events
            string eventSubscriptionId = await baseClient.SubscribeEventsAsync(token);
            if (eventSubscriptionId != null)
            {
                Console.WriteLine($"Subscribed to events with subscription ID: {eventSubscriptionId}");
            }
        }
        else
        {
            Console.WriteLine("Failed to connect to the network.");
        }

        // Disconnect from the network when done
        await baseClient.DisconnectAsync();
        Console.WriteLine("Disconnected from the network.");

        // Ensure to flush log entries
        Log.CloseAndFlush();
    }
}
