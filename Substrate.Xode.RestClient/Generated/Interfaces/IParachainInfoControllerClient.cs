//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Xode.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   
   public interface IParachainInfoControllerClient
   {
      Task<Id> GetParachainId();
      Task<bool> SubscribeParachainId();
   }
}
