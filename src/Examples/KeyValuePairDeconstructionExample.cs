using System.Collections.Generic;
using System;
using System.Linq;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace Pri.ProductivityExtensions.Source.Examples;

public static class KeyValuePairDeconstructionExample
{
	public static (string key, int value) DeconstructKeyValuePairExample()
	{
		var dictionary = new Dictionary<string, int>
		{
			{ "One", 1 },
		};
		(string? key, int value) = dictionary.First();
		return (key, value);
	}
}