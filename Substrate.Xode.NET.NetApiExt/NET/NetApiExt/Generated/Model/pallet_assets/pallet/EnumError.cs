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


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_assets.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> BalanceLow
        /// Account balance must be greater than or equal to the transfer amount.
        /// </summary>
        BalanceLow = 0,
        
        /// <summary>
        /// >> NoAccount
        /// The account to alter does not exist.
        /// </summary>
        NoAccount = 1,
        
        /// <summary>
        /// >> NoPermission
        /// The signing account has no permission to do the operation.
        /// </summary>
        NoPermission = 2,
        
        /// <summary>
        /// >> Unknown
        /// The given asset ID is unknown.
        /// </summary>
        Unknown = 3,
        
        /// <summary>
        /// >> Frozen
        /// The origin account is frozen.
        /// </summary>
        Frozen = 4,
        
        /// <summary>
        /// >> InUse
        /// The asset ID is already taken.
        /// </summary>
        InUse = 5,
        
        /// <summary>
        /// >> BadWitness
        /// Invalid witness data given.
        /// </summary>
        BadWitness = 6,
        
        /// <summary>
        /// >> MinBalanceZero
        /// Minimum balance should be non-zero.
        /// </summary>
        MinBalanceZero = 7,
        
        /// <summary>
        /// >> UnavailableConsumer
        /// Unable to increment the consumer reference counters on the account. Either no provider
        /// reference exists to allow a non-zero balance of a non-self-sufficient asset, or one
        /// fewer then the maximum number of consumers has been reached.
        /// </summary>
        UnavailableConsumer = 8,
        
        /// <summary>
        /// >> BadMetadata
        /// Invalid metadata given.
        /// </summary>
        BadMetadata = 9,
        
        /// <summary>
        /// >> Unapproved
        /// No approval exists that would allow the transfer.
        /// </summary>
        Unapproved = 10,
        
        /// <summary>
        /// >> WouldDie
        /// The source account would not survive the transfer and it needs to stay alive.
        /// </summary>
        WouldDie = 11,
        
        /// <summary>
        /// >> AlreadyExists
        /// The asset-account already exists.
        /// </summary>
        AlreadyExists = 12,
        
        /// <summary>
        /// >> NoDeposit
        /// The asset-account doesn't have an associated deposit.
        /// </summary>
        NoDeposit = 13,
        
        /// <summary>
        /// >> WouldBurn
        /// The operation would result in funds being burned.
        /// </summary>
        WouldBurn = 14,
        
        /// <summary>
        /// >> LiveAsset
        /// The asset is a live asset and is actively being used. Usually emit for operations such
        /// as `start_destroy` which require the asset to be in a destroying state.
        /// </summary>
        LiveAsset = 15,
        
        /// <summary>
        /// >> AssetNotLive
        /// The asset is not live, and likely being destroyed.
        /// </summary>
        AssetNotLive = 16,
        
        /// <summary>
        /// >> IncorrectStatus
        /// The asset status is not the expected status.
        /// </summary>
        IncorrectStatus = 17,
        
        /// <summary>
        /// >> NotFrozen
        /// The asset should be frozen before the given operation.
        /// </summary>
        NotFrozen = 18,
        
        /// <summary>
        /// >> CallbackFailed
        /// Callback action resulted in error
        /// </summary>
        CallbackFailed = 19,
    }
    
    /// <summary>
    /// >> 278 - Variant[pallet_assets.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
