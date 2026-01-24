using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class ThrowIfNullExampleShould
{
	[Fact]
	public void ThrowArgumentNullExceptionWhenArgumentIsNull()
	{
		var ex = Assert.Throws<ArgumentNullException>(() => ThrowIfNullExample.ValidateNotNull(null));
		Assert.Equal("Value cannot be null. (Parameter 'obj')", ex.Message);
	}

	[Fact]
	public void NoThrowArgumentNullExceptionWhenArgumentNoIsNull()
	{
		ThrowIfNullExample.ValidateNotNull("text");
	}
}