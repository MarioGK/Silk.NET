// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("9218e6bb-f944-4f7e-a75c-b1b2c7b701f3")]
    [NativeName("Name", "ID3D12Device8")]
    public unsafe partial struct ID3D12Device8
    {
        public static readonly Guid Guid = new("9218e6bb-f944-4f7e-a75c-b1b2c7b701f3");

        public static implicit operator ID3D12Device7(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device7>(ref val);

        public static implicit operator ID3D12Device6(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device6>(ref val);

        public static implicit operator ID3D12Device5(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device5>(ref val);

        public static implicit operator ID3D12Device4(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device4>(ref val);

        public static implicit operator ID3D12Device3(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device3>(ref val);

        public static implicit operator ID3D12Device2(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device2>(ref val);

        public static implicit operator ID3D12Device1(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device1>(ref val);

        public static implicit operator ID3D12Device(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Device>(ref val);

        public static implicit operator ID3D12Object(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Device8 val)
            => Unsafe.As<ID3D12Device8, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Device8
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeCount()
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue(ref CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandQueueDesc*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riid, ppCommandAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandListType, Guid*, void**, int>)LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState(ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState(ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCommandListPtr = &ppCommandList)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Feature, void*, uint, int>)LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Feature, void*, uint, int>)LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap(ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapDesc*, Guid*, void**, int>)LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDescriptorHandleIncrementSize(DescriptorHeapType DescriptorHeapType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, DescriptorHeapType, uint>)LpVtbl[15])(@this, DescriptorHeapType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateConstantBufferView(ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)LpVtbl[17])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateConstantBufferView(ref ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)LpVtbl[17])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ref ID3D12Resource pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateShaderResourceView(ref ID3D12Resource pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ref ID3D12Resource pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateRenderTargetView(ref ID3D12Resource pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ref ID3D12Resource pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateDepthStencilView(ref ID3D12Resource pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSampler(SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, SamplerDesc*, CpuDescriptorHandle, void>)LpVtbl[22])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateSampler(ref SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SamplerDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, SamplerDesc*, CpuDescriptorHandle, void>)LpVtbl[22])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyDescriptors(uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyDescriptorsSimple(uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly HeapProperties GetCustomHeapProperties(uint nodeMask, HeapType heapType)
        {
            HeapProperties silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            HeapProperties* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, uint, HeapType, HeapProperties*>)LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap(ref HeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, Guid*, void**, int>)LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        fixed (void** pHandlePtr = &pHandle)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
            SilkMarshal.Free((nint)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, void** ppvObj)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riid, ppvObj);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, void** ppvObj)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName(char* Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, uint, void**, int>)LpVtbl[33])(@this, Name, Access, pNTHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName(char* Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, uint, void**, int>)LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName(ref char Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName(ref char Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pNTHandlePtr = &pNTHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, char*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, byte*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, byte*, uint, void**, int>)LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, int>)LpVtbl[34])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, ref ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, int>)LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Evict(uint NumObjects, ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, int>)LpVtbl[35])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Evict(uint NumObjects, ref ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, int>)LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppFencePtr = &ppFence)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ulong, FenceFlags, Guid*, void**, int>)LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceRemovedReason()
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, int>)LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCopyableFootprints(ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap(ref QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, QueryHeapDesc*, Guid*, void**, int>)LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStablePowerState(int Enable)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, int, int>)LpVtbl[40])(@this, Enable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature(ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Luid GetAdapterLuid()
        {
            Luid silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Luid* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Luid*, Luid*>)LpVtbl[43])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary(void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary(void* pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibraryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary(void* pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibrary);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary(void* pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibraryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>(ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibrary);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>(ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibraryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>(ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibrary);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>(ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, nuint, Guid*, void**, int>)LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibraryPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion(ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEvent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>(ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEventPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion(ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEvent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>(ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion(ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEvent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>(ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEventPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion(ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (ulong* pFenceValuesPtr = &pFenceValues)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEvent);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>(ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (ulong* pFenceValuesPtr = &pFenceValues)
                {
                    fixed (void* hEventPtr = &hEvent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, ID3D12Pageable** ppObjects, ResidencyPriority* pPriorities)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, ResidencyPriority*, int>)LpVtbl[46])(@this, NumObjects, ppObjects, pPriorities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, ID3D12Pageable** ppObjects, ref ResidencyPriority pPriorities)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, ResidencyPriority*, int>)LpVtbl[46])(@this, NumObjects, ppObjects, pPrioritiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, ref ID3D12Pageable* ppObjects, ResidencyPriority* pPriorities)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, ResidencyPriority*, int>)LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPriorities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, ref ID3D12Pageable* ppObjects, ref ResidencyPriority pPriorities)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, ID3D12Pageable**, ResidencyPriority*, int>)LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPrioritiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState(ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, PipelineStateStreamDesc*, Guid*, void**, int>)LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress(void* pAddress, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddress, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress(void* pAddress, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddress, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress(void* pAddress, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddress, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress(void* pAddress, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddress, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>(ref T0 pAddress, Guid* riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddressPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>(ref T0 pAddress, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddressPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>(ref T0 pAddress, ref Guid riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>(ref T0 pAddress, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMapping, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMapping, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, Guid* riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, ref Guid riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void*, Guid*, void**, int>)LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignalPtr, FenceValueToSignal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignal, FenceValueToSignal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignalPtr, FenceValueToSignal);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ProtectedResourceSessionDesc* pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDesc, riid, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ProtectedResourceSessionDesc* pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDesc, riid, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ProtectedResourceSessionDesc* pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDesc, riidPtr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ProtectedResourceSessionDesc* pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDesc, riidPtr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ref ProtectedResourceSessionDesc pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDescPtr, riid, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ref ProtectedResourceSessionDesc pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDescPtr, riid, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ref ProtectedResourceSessionDesc pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDescPtr, riidPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession(ref ProtectedResourceSessionDesc pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc*, Guid*, void**, int>)LpVtbl[52])(@this, pDescPtr, riidPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                fixed (void** ppvResourcePtr = &ppvResource)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1(ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvHeapPtr = &ppvHeap)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1(ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1Ptr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1Ptr);
                }
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, Guid* riid, void** ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwner, riid, ppvTracker);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, Guid* riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwner, riid, ppvTrackerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, ref Guid riid, void** ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwner, riidPtr, ppvTracker);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, ref Guid riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwner, riidPtr, ppvTrackerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, Guid* riid, void** ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwnerPtr, riid, ppvTracker);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, Guid* riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwnerPtr, riid, ppvTrackerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, ref Guid riid, void** ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTracker);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, ref Guid riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvTrackerPtr = &ppvTracker)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTrackerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void RemoveDevice()
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, void>)LpVtbl[58])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(uint* pNumMetaCommands, MetaCommandDesc* pDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint*, MetaCommandDesc*, int>)LpVtbl[59])(@this, pNumMetaCommands, pDescs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(uint* pNumMetaCommands, ref MetaCommandDesc pDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetaCommandDesc* pDescsPtr = &pDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint*, MetaCommandDesc*, int>)LpVtbl[59])(@this, pNumMetaCommands, pDescsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(ref uint pNumMetaCommands, MetaCommandDesc* pDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint*, MetaCommandDesc*, int>)LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateMetaCommands(ref uint pNumMetaCommands, ref MetaCommandDesc pDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
            {
                fixed (MetaCommandDesc* pDescsPtr = &pDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, uint*, MetaCommandDesc*, int>)LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (uint* pParameterCountPtr = &pParameterCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (uint* pParameterCountPtr = &pParameterCount)
                    {
                        fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, Guid*, uint, void*, nuint, Guid*, void**, int>)LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(StateObjectDesc* pDesc, Guid* riid, void** ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDesc, riid, ppStateObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(StateObjectDesc* pDesc, Guid* riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDesc, riid, ppStateObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(StateObjectDesc* pDesc, ref Guid riid, void** ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDesc, riidPtr, ppStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(StateObjectDesc* pDesc, ref Guid riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDesc, riidPtr, ppStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(ref StateObjectDesc pDesc, Guid* riid, void** ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDescPtr, riid, ppStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(ref StateObjectDesc pDesc, Guid* riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDescPtr, riid, ppStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(ref StateObjectDesc pDesc, ref Guid riid, void** ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject(ref StateObjectDesc pDesc, ref Guid riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppStateObjectPtr = &ppStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, Guid*, void**, int>)LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo(BuildRaytracingAccelerationStructureInputs* pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)LpVtbl[63])(@this, pDesc, pInfo);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo(BuildRaytracingAccelerationStructureInputs* pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)LpVtbl[63])(@this, pDesc, pInfoPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo(ref BuildRaytracingAccelerationStructureInputs pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)LpVtbl[63])(@this, pDescPtr, pInfo);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetRaytracingAccelerationStructurePrebuildInfo(ref BuildRaytracingAccelerationStructureInputs pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
            {
                fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)LpVtbl[63])(@this, pDescPtr, pInfoPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(SerializedDataType SerializedDataType, SerializedDataDriverMatchingIdentifier* pIdentifierToCheck)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DriverMatchingIdentifierStatus ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheck);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(SerializedDataType SerializedDataType, ref SerializedDataDriverMatchingIdentifier pIdentifierToCheck)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DriverMatchingIdentifierStatus ret = default;
            fixed (SerializedDataDriverMatchingIdentifier* pIdentifierToCheckPtr = &pIdentifierToCheck)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheckPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesiredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode<T0>(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesired);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackgroundProcessingMode<T0>(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired) where T0 : unmanaged
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
            {
                fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesiredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
                {
                    fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddToStateObject(ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ProtectedResourceSessionDesc1* pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDesc, riid, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ProtectedResourceSessionDesc1* pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDesc, riid, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ProtectedResourceSessionDesc1* pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDesc, riidPtr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ProtectedResourceSessionDesc1* pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDesc, riidPtr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDescPtr, riid, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDescPtr, riid, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDescPtr, riidPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession1(ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)LpVtbl[67])(@this, pDescPtr, riidPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo2(uint visibleMask, uint numResourceDescs, ResourceDesc1* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc1*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[68])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo2(uint visibleMask, uint numResourceDescs, ResourceDesc1* pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc1*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[68])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1Ptr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo2(uint visibleMask, uint numResourceDescs, ref ResourceDesc1 pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc1* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc1*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[68])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo2(uint visibleMask, uint numResourceDescs, ref ResourceDesc1 pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc1* pResourceDescsPtr = &pResourceDescs)
            {
                fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceAllocationInfo*, uint, uint, ResourceDesc1*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)LpVtbl[68])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1Ptr);
                }
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc1* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource2(ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc1 pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                fixed (void** ppvResourcePtr = &ppvResource)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[69])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc1* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc1* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource1(ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc1 pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc1* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)LpVtbl[70])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSamplerFeedbackUnorderedAccessView(ID3D12Resource* pTargetedResource, ID3D12Resource* pFeedbackResource, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, CpuDescriptorHandle, void>)LpVtbl[71])(@this, pTargetedResource, pFeedbackResource, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSamplerFeedbackUnorderedAccessView(ID3D12Resource* pTargetedResource, ref ID3D12Resource pFeedbackResource, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pFeedbackResourcePtr = &pFeedbackResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, CpuDescriptorHandle, void>)LpVtbl[71])(@this, pTargetedResource, pFeedbackResourcePtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSamplerFeedbackUnorderedAccessView(ref ID3D12Resource pTargetedResource, ID3D12Resource* pFeedbackResource, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTargetedResourcePtr = &pTargetedResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, CpuDescriptorHandle, void>)LpVtbl[71])(@this, pTargetedResourcePtr, pFeedbackResource, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateSamplerFeedbackUnorderedAccessView(ref ID3D12Resource pTargetedResource, ref ID3D12Resource pFeedbackResource, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTargetedResourcePtr = &pTargetedResource)
            {
                fixed (ID3D12Resource* pFeedbackResourcePtr = &pFeedbackResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ID3D12Resource*, ID3D12Resource*, CpuDescriptorHandle, void>)LpVtbl[71])(@this, pTargetedResourcePtr, pFeedbackResourcePtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCopyableFootprints1(ref ResourceDesc1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc1* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device8*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)LpVtbl[72])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                            }
                        }
                    }
                }
            }
        }

    }
}
