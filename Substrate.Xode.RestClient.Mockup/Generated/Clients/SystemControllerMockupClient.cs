//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.NetApiExt.Generated.Model.frame_system;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NetApiExt.Generated.Model.frame_support.dispatch;
   using Substrate.Xode.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Xode.NetApiExt.Generated.Model.sp_runtime.generic.digest;
   using Substrate.Xode.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SystemControllerMockupClient : MockupBaseClient, ISystemControllerMockupClient
   {
      private HttpClient _httpClient;
      public SystemControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAccount(AccountInfo value, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "System/Account", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.AccountParams(key));
      }
      public async Task<bool> SetExtrinsicCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/ExtrinsicCount", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.ExtrinsicCountParams());
      }
      public async Task<bool> SetBlockWeight(PerDispatchClassT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/BlockWeight", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.BlockWeightParams());
      }
      public async Task<bool> SetAllExtrinsicsLen(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/AllExtrinsicsLen", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.AllExtrinsicsLenParams());
      }
      public async Task<bool> SetBlockHash(H256 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "System/BlockHash", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.BlockHashParams(key));
      }
      public async Task<bool> SetExtrinsicData(BaseVec<U8> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "System/ExtrinsicData", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.ExtrinsicDataParams(key));
      }
      public async Task<bool> SetNumber(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/Number", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.NumberParams());
      }
      public async Task<bool> SetParentHash(H256 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/ParentHash", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.ParentHashParams());
      }
      public async Task<bool> SetDigest(Digest value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/Digest", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.DigestParams());
      }
      public async Task<bool> SetEvents(BaseVec<EventRecord> value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/Events", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.EventsParams());
      }
      public async Task<bool> SetEventCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/EventCount", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.EventCountParams());
      }
      public async Task<bool> SetEventTopics(BaseVec<BaseTuple<U32, U32>> value, H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "System/EventTopics", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.EventTopicsParams(key));
      }
      public async Task<bool> SetLastRuntimeUpgrade(LastRuntimeUpgradeInfo value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/LastRuntimeUpgrade", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.LastRuntimeUpgradeParams());
      }
      public async Task<bool> SetUpgradedToU32RefCount(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/UpgradedToU32RefCount", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.UpgradedToU32RefCountParams());
      }
      public async Task<bool> SetUpgradedToTripleRefCount(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/UpgradedToTripleRefCount", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.UpgradedToTripleRefCountParams());
      }
      public async Task<bool> SetExecutionPhase(EnumPhase value)
      {
         return await SendMockupRequestAsync(_httpClient, "System/ExecutionPhase", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.SystemStorage.ExecutionPhaseParams());
      }
   }
}
