using System;
using System.Collections.Generic;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class EmptyReadOnlyDictionaryExample
{
	public static IReadOnlyDictionary<TKey, TValue> GetReadOnlyDictionary<TKey, TValue>()
	{
		return IReadOnlyDictionary<TKey, TValue>.Empty;
	}
}