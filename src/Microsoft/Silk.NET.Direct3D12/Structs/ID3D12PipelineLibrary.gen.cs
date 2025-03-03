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
    [Guid("c64226a8-9201-46af-b4cc-53fb9ff7414f")]
    [NativeName("Name", "ID3D12PipelineLibrary")]
    public unsafe partial struct ID3D12PipelineLibrary
    {
        public static readonly Guid Guid = new("c64226a8-9201-46af-b4cc-53fb9ff7414f");

        public static implicit operator ID3D12DeviceChild(ID3D12PipelineLibrary val)
            => Unsafe.As<ID3D12PipelineLibrary, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12PipelineLibrary val)
            => Unsafe.As<ID3D12PipelineLibrary, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12PipelineLibrary val)
            => Unsafe.As<ID3D12PipelineLibrary, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12PipelineLibrary
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
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(char* pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pName, pPipeline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(char* pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pName, pPipelinePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(ref char pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipeline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline(ref char pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipeline);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetSerializedSize()
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, nuint>)LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(void* pData, nuint DataSizeInBytes)
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, void*, nuint, int>)LpVtbl[12])(@this, pData, DataSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Serialize<T0>(ref T0 pData, nuint DataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, void*, nuint, int>)LpVtbl[12])(@this, pDataPtr, DataSizeInBytes);
            }
            return ret;
        }

    }
}
