// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using WixToolset.BootstrapperCore;
using WixToolset.WixBA;


[assembly: AssemblyTitle("WixToolset.WixBA")]
[assembly: AssemblyDescription("WiX Bootstrapper Application")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: Guid("0ffc4944-9295-40b7-adac-3a6864b5219b")]
[assembly: CLSCompliantAttribute(true)]

// Identifies the class that derives from IBootstrapperApplicationFactory and is the BAFactory class that gets
// instantiated by the interop layer
[assembly: BootstrapperApplicationFactory(typeof(WixBAFactory))]
