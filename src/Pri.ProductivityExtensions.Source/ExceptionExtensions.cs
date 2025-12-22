// copyright:
//   author: Peter Ritchie
//   file: ExceptionExtensions.cs
//   description: >
//     Defines extension methods that,
//     when used in .NET Standard 2.0, implements the following:
//     -  ArgumentException.ThrowIfNullOrWhiteSpace
//	   -  ArgumentNullException.ThrowIfNull
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

using System.Runtime.CompilerServices;

namespace System;

/// <summary>
/// Provides extension methods for handling exceptions and validating arguments.
/// </summary>
public static class ExceptionExtensions
{
	extension(ArgumentException)
	{
		/// <summary>Throws an exception if <paramref name="argument"/> is null, empty, or consists only of white-space characters.</summary>
		/// <param name="argument">The string argument to validate.</param>
		/// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
		/// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
		/// <exception cref="ArgumentException"><paramref name="argument"/> is empty or consists only of white-space characters.</exception>
		public static void ThrowIfNullOrWhiteSpace(string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
		{
			if (string.IsNullOrWhiteSpace(argument))
			{
				ArgumentNullException.ThrowIfNull(argument, paramName);
				throw new ArgumentException("The value cannot be an empty string or composed entirely of whitespace.", paramName);
			}
		}
	}

	extension(ArgumentNullException)
	{
		/// <summary>Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.</summary>
		/// <param name="argument">The reference type argument to validate as non-null.</param>
		/// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
		public static void ThrowIfNull(object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
		{
			if (argument is null)
			{
				throw new ArgumentNullException(paramName);
			}
		}
	}
}
