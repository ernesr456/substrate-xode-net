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
   using Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage;
   using Substrate.Xode.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ContractsControllerMockupClient : MockupBaseClient, IContractsControllerMockupClient
   {
      private HttpClient _httpClient;
      public ContractsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPristineCode(BoundedVecT13 value, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/PristineCode", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.PristineCodeParams(key));
      }
      public async Task<bool> SetCodeStorage(PrefabWasmModule value, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/CodeStorage", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.CodeStorageParams(key));
      }
      public async Task<bool> SetOwnerInfoOf(OwnerInfo value, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/OwnerInfoOf", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.OwnerInfoOfParams(key));
      }
      public async Task<bool> SetNonce(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/Nonce", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.NonceParams());
      }
      public async Task<bool> SetContractInfoOf(ContractInfo value, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/ContractInfoOf", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.ContractInfoOfParams(key));
      }
      public async Task<bool> SetDeletionQueue(BoundedVecT14 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/DeletionQueue", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.DeletionQueueParams(key));
      }
      public async Task<bool> SetDeletionQueueCounter(DeletionQueueManager value)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/DeletionQueueCounter", value.Encode(), Substrate.Xode.NetApiExt.Generated.Storage.ContractsStorage.DeletionQueueCounterParams());
      }
   }
}
