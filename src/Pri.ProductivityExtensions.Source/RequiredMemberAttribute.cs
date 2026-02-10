// copyright:
//   author: Peter Ritchie
//   file: RequiredMemberAttribute.cs
//   description: >
//     Defines the RequiredMemberAttribute attribute that,
//     when used in .NET Standard 2.0, enables language support for
//     <code>required</code> keyword.
//   Original source:
//	  https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/RequiredMemberAttribute.cs
//   License: MIT
//   statement: >
//     Copyright (c) 2026 Peter Ritchie. All rights reserved.
//     Permission is hereby granted, free of charge, to any person obtaining a
//     copy of this software and associated documentation files (the
//     “Software”), to deal in the Software without restriction, including
//     without limitation the rights to use, copy, modify, merge, publish,
//     distribute, sublicense, and/or sell copies of the Software, and to
//     permit persons to whom the Software is furnished to do so, subject to
//     the following conditions:
//
//     The above copyright notice and this permission notice shall be included
//     in all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//     MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//     CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//     TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//     SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#pragma warning disable IDE0130
// ReSharper disable once CheckNamespace
using System.ComponentModel;

namespace System.Runtime.CompilerServices;
#pragma warning restore IDE0130

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
[EditorBrowsable(EditorBrowsableState.Never)] 
internal sealed class RequiredMemberAttribute : Attribute;