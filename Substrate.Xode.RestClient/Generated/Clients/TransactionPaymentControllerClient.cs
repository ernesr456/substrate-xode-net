//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using Substrate.Xode.NetApiExt.Generated.Model.pallet_transaction_payment;
   using Substrate.Xode.RestClient.Generated.Interfaces;
   
   public sealed class TransactionPaymentControllerClient : BaseClient, ITransactionPaymentControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TransactionPaymentControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<FixedU128> GetNextFeeMultiplier()
      {
         return await SendRequestAsync<FixedU128>(_httpClient, "transactionpayment/nextfeemultiplier");
      }
      public async Task<bool> SubscribeNextFeeMultiplier()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionPayment.NextFeeMultiplier");
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "transactionpayment/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionPayment.StorageVersion");
      }
   }
}
