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
   using Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface ICollatorSelectionControllerMockupClient
   {
      Task<bool> SetInvulnerables(BoundedVecT6 value);
      Task<bool> SetCandidates(BoundedVecT7 value);
      Task<bool> SetLastAuthoredBlock(U32 value, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetDesiredCandidates(U32 value);
      Task<bool> SetCandidacyBond(U128 value);
   }
}
