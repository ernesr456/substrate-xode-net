//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.RestClient.Mockup.Generated.Clients;
   using Substrate.Xode.RestClient.Generated.Clients;
   using Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public class AuraControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 GetTestValue2()
      {
         Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 result;
         result = new Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public>();
         result.Value.Create(new Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public GetTestValue3()
      {
         Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public result;
         result = new Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Value = new Substrate.Xode.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue4();
         return result;
      }
      public Substrate.Xode.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue4()
      {
         Substrate.Xode.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new Substrate.Xode.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = new Substrate.Xode.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAuthorities()
      {
         // Construct new Mockup client to test with.
         AuraControllerMockupClient mockupClient = new AuraControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuraControllerClient rpcClient = new AuraControllerClient(_httpClient, subscriptionClient);
         Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeAuthorities());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAuthorities(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 rpcResult = await rpcClient.GetAuthorities();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots.Slot GetTestValue6()
      {
         Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots.Slot result;
         result = new Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots.Slot();
         result.Value = this.GetTestValueU64();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCurrentSlot()
      {
         // Construct new Mockup client to test with.
         AuraControllerMockupClient mockupClient = new AuraControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuraControllerClient rpcClient = new AuraControllerClient(_httpClient, subscriptionClient);
         Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots.Slot mockupValue = this.GetTestValue6();


         Assert.IsTrue(await rpcClient.SubscribeCurrentSlot());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCurrentSlot(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Xode.NetApiExt.Generated.Model.sp_consensus_slots.Slot rpcResult = await rpcClient.GetCurrentSlot();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
