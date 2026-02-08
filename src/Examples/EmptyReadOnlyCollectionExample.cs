using System;
using System.Collections.Generic;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class EmptyReadOnlyCollectionExample
{
	public static IReadOnlyCollection<T> GetReadOnlyCollection<T>()
	{
#pragma warning disable IDE0301 // Simplify collection initialization
		return IReadOnlyCollection<T>.Empty;
#pragma warning restore IDE0301 // Simplify collection initialization
	}
}