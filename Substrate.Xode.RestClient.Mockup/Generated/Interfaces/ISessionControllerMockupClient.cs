//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NetApiExt.Generated.Model.humidefi_runtime;
   
   public interface ISessionControllerMockupClient
   {
      Task<bool> SetValidators(BaseVec<AccountId32> value);
      Task<bool> SetCurrentIndex(U32 value);
      Task<bool> SetQueuedChanged(Bool value);
      Task<bool> SetQueuedKeys(BaseVec<BaseTuple<AccountId32, SessionKeys>> value);
      Task<bool> SetDisabledValidators(BaseVec<U32> value);
      Task<bool> SetNextKeys(SessionKeys value, AccountId32 key);
      Task<bool> SetKeyOwner(AccountId32 value, BaseTuple<KeyTypeId, BaseVec<U8>> key);
   }
}
