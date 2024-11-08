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
   using Substrate.Xode.NetApiExt.Generated.Model.pallet_assets.types;
   
   public interface IAssetsControllerMockupClient
   {
      Task<bool> SetAsset(AssetDetails value, Substrate.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SetAccount(AssetAccount value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SetApprovals(Approval value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SetMetadata(AssetMetadata value, Substrate.NetApi.Model.Types.Primitive.U32 key);
   }
}
