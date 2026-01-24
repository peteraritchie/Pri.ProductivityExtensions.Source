using System;
// ReSharper disable AccessToStaticMemberViaDerivedType

namespace Pri.ProductivityExtensions.Source.Examples;

public static class ThrowIfNullOrWhiteSpaceExample
{
	public static void ValidateNotNullOrWhiteSpace(string? str)
	{
		ArgumentNullException.ThrowIfNullOrWhiteSpace(str);
	}
}