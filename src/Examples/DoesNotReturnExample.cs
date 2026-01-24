using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace Pri.ProductivityExtensions.Source.Examples;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static class DoesNotReturnExample
{
	[DoesNotReturn]
	private static void ShouldNotReturn()
	{
		throw new NotImplementedException();
	}

	public static void CallShouldNotReturn()
	{
		ShouldNotReturn();
		Trace.WriteLine("This line is not reachable.");
	}
}