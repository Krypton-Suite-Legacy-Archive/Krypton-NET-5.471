﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Security;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion("4.71.502.0")]
[assembly: AssemblyFileVersion("4.71.502.0")]
[assembly: AssemblyCopyright("© Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)")]
[assembly: AssemblyInformationalVersion("4.71.502.0")]
[assembly: AssemblyProduct("Krypton Workspace")]
[assembly: AssemblyDefaultAlias("ComponentFactory.Krypton.Workspace.dll")]
[assembly: AssemblyTitle("ComponentFactory.Krypton.Workspace")]
[assembly: AssemblyCompany("Component Factory Pty Ltd, Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV)")]
[assembly: AssemblyDescription("ComponentFactory.Krypton.Workspace")]
[assembly: AssemblyConfiguration("Production")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: StringFreezing]
[assembly: ComVisible(true)]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers()]
[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Toolkit", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Navigator", LoadHint.Always)]
[assembly: SecurityRules(SecurityRuleSet.Level1)]