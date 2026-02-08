// copyright:
//   author: Peter Ritchie
//   file: CollectionsExtensions.cs
//   description: >
//     Defines extension methods that,
//     when used in .NET Standard 2.0, implements the following:
//     -   IReadOnlyDictionary<TKey, TValue>.Empty
//     -   IReadOnlyCollection<T>.Empty
//   License: MIT
//   statement: >
//     Copyright (c) 2025 Peter Ritchie. All rights reserved.
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
using System.Collections.Generic;
using System.Collections.ObjectModel;

#pragma warning disable IDE0130
namespace System;
#pragma warning restore IDE0130

/// <summary>
/// Some extensions for things in new .NET libraries.
/// </summary>
public static class CollectionsExtensions
{
	extension<TKey, TValue>(IReadOnlyDictionary<TKey, TValue>) // where TKey : notnull
	{
		/// <summary>
		/// A singleton instance of an empty IReadOnlyDictionary
		/// </summary>
		public static IReadOnlyDictionary<TKey, TValue> Empty
			=> new ReadOnlyDictionary<TKey, TValue>(new Dictionary<TKey, TValue>());
	}
	extension<T>(IReadOnlyCollection<T>) //where T : notnull
	{
		/// <summary>
		/// A singleton instance of an empty IReadOnlyCollection
		/// </summary>
		public static IReadOnlyCollection<T> Empty
			=> new ReadOnlyCollection<T>(new Collection<T>());
	}
}