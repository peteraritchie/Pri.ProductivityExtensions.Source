using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class DictionaryEntryDeconstructionExampleShould
{
	[Fact]
	public void DeconstructDictionaryEntryCorrectly()
	{
		// Act
		var (key, value) = DictionaryEntryDeconstructionExample.DeconstructionDictionaryEntryExample();
		// Assert
		Assert.Equal("A", key);
		Assert.Equal(100, value);
	}
}