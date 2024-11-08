//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Xode.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> ContractsStorage
    /// </summary>
    public sealed class ContractsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ContractsStorage Constructor
        /// </summary>
        public ContractsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "PristineCode"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "CodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "OwnerInfoOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "Nonce"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "ContractInfoOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "DeletionQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "DeletionQueueCounter"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.DeletionQueueManager)));
        }
        
        /// <summary>
        /// >> PristineCodeParams
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public static string PristineCodeParams(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "PristineCode", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PristineCodeDefault
        /// Default value as hex string
        /// </summary>
        public static string PristineCodeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13> PristineCode(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.PristineCodeParams(key);
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CodeStorageParams
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public static string CodeStorageParams(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "CodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule> CodeStorage(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.CodeStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> OwnerInfoOfParams
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public static string OwnerInfoOfParams(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "OwnerInfoOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OwnerInfoOfDefault
        /// Default value as hex string
        /// </summary>
        public static string OwnerInfoOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo> OwnerInfoOf(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.OwnerInfoOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NonceParams
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        public static string NonceParams()
        {
            return RequestGenerator.GetStorage("Contracts", "Nonce", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NonceDefault
        /// Default value as hex string
        /// </summary>
        public static string NonceDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> Nonce
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> Nonce(string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.NonceParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ContractInfoOfParams
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public static string ContractInfoOfParams(Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Contracts", "ContractInfoOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ContractInfoOfDefault
        /// Default value as hex string
        /// </summary>
        public static string ContractInfoOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo> ContractInfoOf(Substrate.Xode.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.ContractInfoOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> DeletionQueueParams
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_idle`.
        /// </summary>
        public static string DeletionQueueParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Contracts", "DeletionQueue", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> DeletionQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string DeletionQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_idle`.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14> DeletionQueue(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.DeletionQueueParams(key);
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> DeletionQueueCounterParams
        ///  A pair of monotonic counters used to track the latest contract marked for deletion
        ///  and the latest deleted contract in queue.
        /// </summary>
        public static string DeletionQueueCounterParams()
        {
            return RequestGenerator.GetStorage("Contracts", "DeletionQueueCounter", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DeletionQueueCounterDefault
        /// Default value as hex string
        /// </summary>
        public static string DeletionQueueCounterDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> DeletionQueueCounter
        ///  A pair of monotonic counters used to track the latest contract marked for deletion
        ///  and the latest deleted contract in queue.
        /// </summary>
        public async Task<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.DeletionQueueManager> DeletionQueueCounter(string blockhash, CancellationToken token)
        {
            string parameters = ContractsStorage.DeletionQueueCounterParams();
            var result = await _client.GetStorageAsync<Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.storage.DeletionQueueManager>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ContractsCalls
    /// </summary>
    public sealed class ContractsCalls
    {
        
        /// <summary>
        /// >> call_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CallOldWeight(Substrate.Xode.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(60, "Contracts", 0, "call_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCodeOldWeight(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(60, "Contracts", 1, "instantiate_with_code_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateOldWeight(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 code_hash, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(60, "Contracts", 2, "instantiate_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upload_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UploadCode(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.wasm.EnumDeterminism determinism)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(determinism.Encode());
            return new Method(60, "Contracts", 3, "upload_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveCode(Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code_hash.Encode());
            return new Method(60, "Contracts", 4, "remove_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCode(Substrate.Xode.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(code_hash.Encode());
            return new Method(60, "Contracts", 5, "set_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Call(Substrate.Xode.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Xode.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(60, "Contracts", 6, "call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCode(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Xode.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(60, "Contracts", 7, "instantiate_with_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Instantiate(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Xode.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Xode.NetApiExt.Generated.Model.primitive_types.H256 code_hash, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(60, "Contracts", 8, "instantiate", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ContractsConstants
    /// </summary>
    public sealed class ContractsConstants
    {
        
        /// <summary>
        /// >> Schedule
        ///  Cost schedule and limits.
        /// </summary>
        public Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.schedule.Schedule Schedule()
        {
            var result = new Substrate.Xode.NetApiExt.Generated.Model.pallet_contracts.schedule.Schedule();
            result.Create(@"0x040000000001000000040000800000001000000000100000000100002000000000400000000000400400000000000000C3050000340E0000000C0000F3070000031800007E060000FF0D0000A114000004000000F1400000C74D0000110400006003000090080000950300005A1C0000C41C0000E9080000611ECB006E0300002C03000024030000DB020000A2030000B20300000703000054060000520700003A0600003B0600006F050000990600001D0600006F050000030600003C060000C1050000C10600005C050000491C0000E3170000331D000099180000EA04000033050000E2050000A2050000B00600009E050000D905000096050000CAC3130018C21DC1066D2AA61BF2067D2AF64F1900181E380A000CDEDB08000CA61D140018B2A31F001826C058001876F21300189ECE130018BA68130018BA551300180AAB540038EECE0700008A201100184D09003E8F3800B4D5020016C2FEFD9579B6AE6B0028DABFD200289EF5641E3127D10B007A120E001C850B0036E43F1F9504D90600A50104A205D6464930CA1D361F8504F50104CE271B078504000402412307A504090B040A71441FA504A10B04BE9C3C2661274EA8516F012B8EA391563128FA06DE4289506509005E2D5DEE5551FAC9B03B29297D1200211500CE07230020B53D001A552D0020653100EA80190020450E0096711900205D0E00061CF7083501B25D3A02A80642770BC10111490466BD09000C36AF0F00A0C2C008000C");
            return result;
        }
        
        /// <summary>
        /// >> DepositPerByte
        ///  The amount of balance a caller has to pay for each byte of storage.
        /// 
        ///  # Note
        /// 
        ///  Changing this value for an existing chain might need a storage migration.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositPerByte()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x404B4C00000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> DefaultDepositLimit
        ///  Fallback value to limit the storage deposit if it's not being set by the caller.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DefaultDepositLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x0000A08FE66100000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> DepositPerItem
        ///  The amount of balance a caller has to pay for each storage item.
        /// 
        ///  # Note
        /// 
        ///  Changing this value for an existing chain might need a storage migration.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositPerItem()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E87648170000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCodeLen
        ///  The maximum length of a contract code in bytes. This limit applies to the instrumented
        ///  version of the code. Therefore `instantiate_with_code` can fail even when supplying
        ///  a wasm binary below this maximum size.
        /// 
        ///  The value should be chosen carefully taking into the account the overall memory limit
        ///  your runtime has, as well as the [maximum allowed callstack
        ///  depth](#associatedtype.CallStack). Look into the `integrity_test()` for some insights.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCodeLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000400");
            return result;
        }
        
        /// <summary>
        /// >> MaxStorageKeyLen
        ///  The maximum allowable length in bytes for storage keys.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxStorageKeyLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80000000");
            return result;
        }
        
        /// <summary>
        /// >> UnsafeUnstableInterface
        ///  Make contract callable functions marked as `#[unstable]` available.
        /// 
        ///  Contracts that use `#[unstable]` functions won't be able to be uploaded unless
        ///  this is set to `true`. This is only meant for testnets and dev nodes in order to
        ///  experiment with new features.
        /// 
        ///  # Warning
        /// 
        ///  Do **not** set to `true` on productions chains.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool UnsafeUnstableInterface()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.Bool();
            result.Create("0x01");
            return result;
        }
        
        /// <summary>
        /// >> MaxDebugBufferLen
        ///  The maximum length of the debug buffer in bytes.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxDebugBufferLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00002000");
            return result;
        }
    }
    
    /// <summary>
    /// >> ContractsErrors
    /// </summary>
    public enum ContractsErrors
    {
        
        /// <summary>
        /// >> InvalidScheduleVersion
        /// A new schedule must have a greater version than the current one.
        /// </summary>
        InvalidScheduleVersion,
        
        /// <summary>
        /// >> InvalidCallFlags
        /// Invalid combination of flags supplied to `seal_call` or `seal_delegate_call`.
        /// </summary>
        InvalidCallFlags,
        
        /// <summary>
        /// >> OutOfGas
        /// The executed contract exhausted its gas limit.
        /// </summary>
        OutOfGas,
        
        /// <summary>
        /// >> OutputBufferTooSmall
        /// The output buffer supplied to a contract API call was too small.
        /// </summary>
        OutputBufferTooSmall,
        
        /// <summary>
        /// >> TransferFailed
        /// Performing the requested transfer failed. Probably because there isn't enough
        /// free balance in the sender's account.
        /// </summary>
        TransferFailed,
        
        /// <summary>
        /// >> MaxCallDepthReached
        /// Performing a call was denied because the calling depth reached the limit
        /// of what is specified in the schedule.
        /// </summary>
        MaxCallDepthReached,
        
        /// <summary>
        /// >> ContractNotFound
        /// No contract was found at the specified address.
        /// </summary>
        ContractNotFound,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `instantiate_with_code` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> CodeNotFound
        /// No code could be found at the supplied code hash.
        /// </summary>
        CodeNotFound,
        
        /// <summary>
        /// >> OutOfBounds
        /// A buffer outside of sandbox memory was passed to a contract API function.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> DecodingFailed
        /// Input passed to a contract API function failed to decode as expected type.
        /// </summary>
        DecodingFailed,
        
        /// <summary>
        /// >> ContractTrapped
        /// Contract trapped during execution.
        /// </summary>
        ContractTrapped,
        
        /// <summary>
        /// >> ValueTooLarge
        /// The size defined in `T::MaxValueSize` was exceeded.
        /// </summary>
        ValueTooLarge,
        
        /// <summary>
        /// >> TerminatedWhileReentrant
        /// Termination of a contract is not allowed while the contract is already
        /// on the call stack. Can be triggered by `seal_terminate`.
        /// </summary>
        TerminatedWhileReentrant,
        
        /// <summary>
        /// >> InputForwarded
        /// `seal_call` forwarded this contracts input. It therefore is no longer available.
        /// </summary>
        InputForwarded,
        
        /// <summary>
        /// >> RandomSubjectTooLong
        /// The subject passed to `seal_random` exceeds the limit.
        /// </summary>
        RandomSubjectTooLong,
        
        /// <summary>
        /// >> TooManyTopics
        /// The amount of topics passed to `seal_deposit_events` exceeds the limit.
        /// </summary>
        TooManyTopics,
        
        /// <summary>
        /// >> NoChainExtension
        /// The chain does not provide a chain extension. Calling the chain extension results
        /// in this error. Note that this usually  shouldn't happen as deploying such contracts
        /// is rejected.
        /// </summary>
        NoChainExtension,
        
        /// <summary>
        /// >> DuplicateContract
        /// A contract with the same AccountId already exists.
        /// </summary>
        DuplicateContract,
        
        /// <summary>
        /// >> TerminatedInConstructor
        /// A contract self destructed in its constructor.
        /// 
        /// This can be triggered by a call to `seal_terminate`.
        /// </summary>
        TerminatedInConstructor,
        
        /// <summary>
        /// >> ReentranceDenied
        /// A call tried to invoke a contract that is flagged as non-reentrant.
        /// The only other cause is that a call from a contract into the runtime tried to call back
        /// into `pallet-contracts`. This would make the whole pallet reentrant with regard to
        /// contract code execution which is not supported.
        /// </summary>
        ReentranceDenied,
        
        /// <summary>
        /// >> StorageDepositNotEnoughFunds
        /// Origin doesn't have enough balance to pay the required storage deposits.
        /// </summary>
        StorageDepositNotEnoughFunds,
        
        /// <summary>
        /// >> StorageDepositLimitExhausted
        /// More storage was created than allowed by the storage deposit limit.
        /// </summary>
        StorageDepositLimitExhausted,
        
        /// <summary>
        /// >> CodeInUse
        /// Code removal was denied because the code is still in use by at least one contract.
        /// </summary>
        CodeInUse,
        
        /// <summary>
        /// >> ContractReverted
        /// The contract ran to completion but decided to revert its storage changes.
        /// Please note that this error is only returned from extrinsics. When called directly
        /// or via RPC an `Ok` will be returned. In this case the caller needs to inspect the flags
        /// to determine whether a reversion has taken place.
        /// </summary>
        ContractReverted,
        
        /// <summary>
        /// >> CodeRejected
        /// The contract's code was found to be invalid during validation or instrumentation.
        /// 
        /// The most likely cause of this is that an API was used which is not supported by the
        /// node. This happens if an older node is used with a new version of ink!. Try updating
        /// your node to the newest available version.
        /// 
        /// A more detailed error can be found on the node console if debug messages are enabled
        /// by supplying `-lruntime::contracts=debug`.
        /// </summary>
        CodeRejected,
        
        /// <summary>
        /// >> Indeterministic
        /// An indetermistic code was used in a context where this is not permitted.
        /// </summary>
        Indeterministic,
    }
}