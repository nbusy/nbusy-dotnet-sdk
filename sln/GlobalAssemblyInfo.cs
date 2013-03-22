﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalAssemblyInfo.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Reflection;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("NBusy")]
[assembly: AssemblyCopyright("Copyright © Teoman Soygul")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

/*
 * Basic rules to become CLS compliant is below:
 * 1. Unsigned types should not be part of the public interface of the class. What this means is public fields should not 
 * have unsigned types like uint or ulong, public methods should not return unsigned types, parameters passed to public 
 * function should not have unsigned types. However unsigned types can be part of private members.
 * 2. Unsafe types like pointers should not be used with public members. However they can be used with private members.
 * 3. Class names and member names should not differ only based on their case. For example we cannot have two methods 
 * named MyMethod and MYMETHOD.
 * 4. Only properties and methods may be overloaded, Operators should not be overloaded.
 * 
 * [assembly: CLSCompliant(true)]
*/

// Version information for an assembly consists of the following four values:
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0")]

// This is also assigned to 'AssemblyInformationalVersion' which is the product version
// Standard Way: [major].[minor].[bugfix].[build]
// .NET Convention: Third digit is the auto-incremented build version. Fourth digit is revision, which is service pack no
[assembly: AssemblyFileVersion("1.0.0.0")]

/* 
 * AssemblyVersion should only be changed for major changes or breaking changes since Any change to the 
 * AssemblyVersion would force every .NET application referencing mscorlib.dll to re-compile against the 
 * new version!
 * 
 *		Do not change the AssemblyVersion for a servicing release which is intended to be backwards compatible.
 *		Do change the AssemblyVersion for a release that you know has breaking changes.
 * 
 * Remember that it’s the AssemblyFileVersion that contains all the interesting servicing information 
 * (it’s the Revision part of this version that tells you what Service Pack you’re on)
*/