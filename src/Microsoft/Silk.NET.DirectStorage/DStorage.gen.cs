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

namespace Silk.NET.DirectStorage
{
    public unsafe partial class DStorage : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "FACILITY_GAME")]
        public const int FacilityGame = unchecked((int) 0x924);
        [NativeName("Type", "int")]
        [NativeName("Name", "DSTORAGE_SDK_VERSION")]
        public const int SdkVersion = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DSTORAGE_MIN_QUEUE_CAPACITY")]
        public const int MinQueueCapacity = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "DSTORAGE_MAX_QUEUE_CAPACITY")]
        public const int MaxQueueCapacity = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "DSTORAGE_REQUEST_MAX_NAME")]
        public const int RequestMaxName = unchecked((int) 0x40);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageSetConfiguration", Convention = CallingConvention.StdCall)]
        public unsafe partial int SetConfiguration([Flow(FlowDirection.In)] Configuration* configuration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageSetConfiguration", Convention = CallingConvention.StdCall)]
        public partial int SetConfiguration([Flow(FlowDirection.In)] in Configuration configuration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageGetFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFactory(Guid* riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageGetFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFactory(Guid* riid, ref void* ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageGetFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFactory(ref Guid riid, void** ppv);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        [NativeApi(EntryPoint = "DStorageGetFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFactory(ref Guid riid, ref void* ppv);


        public DStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

