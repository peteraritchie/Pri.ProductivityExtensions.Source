using System;
using System.Collections;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace Pri.ProductivityExtensions.Source.Examples;

public static class DictionaryEntryDeconstructionExample
{
	public static (object key, object? value) DeconstructionDictionaryEntryExample()
	{
		var hashtable = new Hashtable
		{
			{ "A", 100 },
		};
		// ReSharper disable once GenericEnumeratorNotDisposed
		IDictionaryEnumerator dictionaryEnumerator = hashtable.GetEnumerator();
		dictionaryEnumerator.MoveNext();
		DictionaryEntry entry = (DictionaryEntry)dictionaryEnumerator.Current;
		(object key, object? value) = entry;
		return (key, value);
	}
}