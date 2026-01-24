using System;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class ThrowIfNullExample
{
	public static void ValidateNotNull(object? obj)
	{
		ArgumentNullException.ThrowIfNull(obj);
	}
}