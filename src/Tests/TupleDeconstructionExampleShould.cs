#if false
using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class TupleDeconstructionExampleShould
{
	[Fact]
	public void DeconstructTupleCorrectly()
	{
		// Act
		var (first, second) = TupleDeconstructionExample.DeconstructExample();
		// Assert
		Assert.Equal(10, first);
		Assert.Equal(20, second);
	}
} 
#endif