using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class DeconstructKeyValuePairExampleShould
{
	[Fact]
	public void DeconstructKeyValuePairCorrectly()
	{
		var (key, value) = 	KeyValuePairDeconstructionExample.DeconstructKeyValuePairExample();
		Assert.Equal("One", key);
		Assert.Equal(1, value);
	}
}