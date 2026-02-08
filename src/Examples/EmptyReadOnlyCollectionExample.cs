using System;
using System.Collections.Generic;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class EmptyReadOnlyCollectionExample
{
	public static IReadOnlyCollection<T> GetReadOnlyCollection<T>()
	{
		return IReadOnlyCollection<T>.Empty;
	}
}