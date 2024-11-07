//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_xcm.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> send
        /// </summary>
        send = 0,
        
        /// <summary>
        /// >> teleport_assets
        /// Teleport some assets from the local chain to some destination chain.
        /// 
        /// Fee payment on the destination side is made from the asset in the `assets` vector of
        /// index `fee_asset_item`. The weight limit for fees is not provided and thus is unlimited,
        /// with all fees taken as needed from the asset.
        /// 
        /// - `origin`: Must be capable of withdrawing the `assets` and executing XCM.
        /// - `dest`: Destination context for the assets. Will typically be `X2(Parent, Parachain(..))` to send
        ///   from parachain to parachain, or `X1(Parachain(..))` to send from relay to parachain.
        /// - `beneficiary`: A beneficiary location for the assets in the context of `dest`. Will generally be
        ///   an `AccountId32` value.
        /// - `assets`: The assets to be withdrawn. The first item should be the currency used to to pay the fee on the
        ///   `dest` side. May not be empty.
        /// - `fee_asset_item`: The index into `assets` of the item which should be used to pay
        ///   fees.
        /// </summary>
        teleport_assets = 1,
        
        /// <summary>
        /// >> reserve_transfer_assets
        /// Transfer some assets from the local chain to the sovereign account of a destination
        /// chain and forward a notification XCM.
        /// 
        /// Fee payment on the destination side is made from the asset in the `assets` vector of
        /// index `fee_asset_item`. The weight limit for fees is not provided and thus is unlimited,
        /// with all fees taken as needed from the asset.
        /// 
        /// - `origin`: Must be capable of withdrawing the `assets` and executing XCM.
        /// - `dest`: Destination context for the assets. Will typically be `X2(Parent, Parachain(..))` to send
        ///   from parachain to parachain, or `X1(Parachain(..))` to send from relay to parachain.
        /// - `beneficiary`: A beneficiary location for the assets in the context of `dest`. Will generally be
        ///   an `AccountId32` value.
        /// - `assets`: The assets to be withdrawn. This should include the assets used to pay the fee on the
        ///   `dest` side.
        /// - `fee_asset_item`: The index into `assets` of the item which should be used to pay
        ///   fees.
        /// </summary>
        reserve_transfer_assets = 2,
        
        /// <summary>
        /// >> execute
        /// Execute an XCM message from a local, signed, origin.
        /// 
        /// An event is deposited indicating whether `msg` could be executed completely or only
        /// partially.
        /// 
        /// No more than `max_weight` will be used in its attempted execution. If this is less than the
        /// maximum amount of weight that the message could take to be executed, then no execution
        /// attempt will be made.
        /// 
        /// NOTE: A successful return to this does *not* imply that the `msg` was executed successfully
        /// to completion; only that *some* of it was executed.
        /// </summary>
        execute = 3,
        
        /// <summary>
        /// >> force_xcm_version
        /// Extoll that a particular destination can be communicated with through a particular
        /// version of XCM.
        /// 
        /// - `origin`: Must be an origin specified by AdminOrigin.
        /// - `location`: The destination that is being described.
        /// - `xcm_version`: The latest version of XCM that `location` supports.
        /// </summary>
        force_xcm_version = 4,
        
        /// <summary>
        /// >> force_default_xcm_version
        /// Set a safe XCM version (the version that XCM should be encoded with if the most recent
        /// version a destination can accept is unknown).
        /// 
        /// - `origin`: Must be an origin specified by AdminOrigin.
        /// - `maybe_xcm_version`: The default XCM encoding version, or `None` to disable.
        /// </summary>
        force_default_xcm_version = 5,
        
        /// <summary>
        /// >> force_subscribe_version_notify
        /// Ask a location to notify us regarding their XCM version and any changes to it.
        /// 
        /// - `origin`: Must be an origin specified by AdminOrigin.
        /// - `location`: The location to which we should subscribe for XCM version notifications.
        /// </summary>
        force_subscribe_version_notify = 6,
        
        /// <summary>
        /// >> force_unsubscribe_version_notify
        /// Require that a particular destination should no longer notify us regarding any XCM
        /// version changes.
        /// 
        /// - `origin`: Must be an origin specified by AdminOrigin.
        /// - `location`: The location to which we are currently subscribed for XCM version
        ///   notifications which we no longer desire.
        /// </summary>
        force_unsubscribe_version_notify = 7,
        
        /// <summary>
        /// >> limited_reserve_transfer_assets
        /// Transfer some assets from the local chain to the sovereign account of a destination
        /// chain and forward a notification XCM.
        /// 
        /// Fee payment on the destination side is made from the asset in the `assets` vector of
        /// index `fee_asset_item`, up to enough to pay for `weight_limit` of weight. If more weight
        /// is needed than `weight_limit`, then the operation will fail and the assets send may be
        /// at risk.
        /// 
        /// - `origin`: Must be capable of withdrawing the `assets` and executing XCM.
        /// - `dest`: Destination context for the assets. Will typically be `X2(Parent, Parachain(..))` to send
        ///   from parachain to parachain, or `X1(Parachain(..))` to send from relay to parachain.
        /// - `beneficiary`: A beneficiary location for the assets in the context of `dest`. Will generally be
        ///   an `AccountId32` value.
        /// - `assets`: The assets to be withdrawn. This should include the assets used to pay the fee on the
        ///   `dest` side.
        /// - `fee_asset_item`: The index into `assets` of the item which should be used to pay
        ///   fees.
        /// - `weight_limit`: The remote-side weight limit, if any, for the XCM fee purchase.
        /// </summary>
        limited_reserve_transfer_assets = 8,
        
        /// <summary>
        /// >> limited_teleport_assets
        /// Teleport some assets from the local chain to some destination chain.
        /// 
        /// Fee payment on the destination side is made from the asset in the `assets` vector of
        /// index `fee_asset_item`, up to enough to pay for `weight_limit` of weight. If more weight
        /// is needed than `weight_limit`, then the operation will fail and the assets send may be
        /// at risk.
        /// 
        /// - `origin`: Must be capable of withdrawing the `assets` and executing XCM.
        /// - `dest`: Destination context for the assets. Will typically be `X2(Parent, Parachain(..))` to send
        ///   from parachain to parachain, or `X1(Parachain(..))` to send from relay to parachain.
        /// - `beneficiary`: A beneficiary location for the assets in the context of `dest`. Will generally be
        ///   an `AccountId32` value.
        /// - `assets`: The assets to be withdrawn. The first item should be the currency used to to pay the fee on the
        ///   `dest` side. May not be empty.
        /// - `fee_asset_item`: The index into `assets` of the item which should be used to pay
        ///   fees.
        /// - `weight_limit`: The remote-side weight limit, if any, for the XCM fee purchase.
        /// </summary>
        limited_teleport_assets = 9,
        
        /// <summary>
        /// >> force_suspension
        /// Set or unset the global suspension state of the XCM executor.
        /// 
        /// - `origin`: Must be an origin specified by AdminOrigin.
        /// - `suspended`: `true` to suspend, `false` to resume.
        /// </summary>
        force_suspension = 10,
    }
    
    /// <summary>
    /// >> 238 - Variant[pallet_xcm.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm>>(Call.send);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.teleport_assets);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.reserve_transfer_assets);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Call.execute);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.force_xcm_version);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.force_default_xcm_version);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>(Call.force_subscribe_version_notify);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>(Call.force_unsubscribe_version_notify);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.limited_reserve_transfer_assets);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiAssets, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.v3.EnumWeightLimit>>(Call.limited_teleport_assets);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.Bool>(Call.force_suspension);
        }
    }
}
