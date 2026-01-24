// ReSharper disable AccessToStaticMemberViaDerivedType

using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class ThrowIfNullOrWhiteSpaceExampleShould
{
	[Fact]
	public void ThrowArgumentNullExceptionWhenArgumentIsNull()
	{
		var ex = Assert.Throws<ArgumentNullException>(() => ThrowIfNullOrWhiteSpaceExample.ValidateNotNullOrWhiteSpace(null));
		Assert.Equal("Value cannot be null. (Parameter 'str')", ex.Message);
	}

	[Fact]
	public void ThrowArgumentExceptionWhenArgumentIsWhitespace()
	{
		var ex = Assert.Throws<ArgumentException>(() => ThrowIfNullOrWhiteSpaceExample.ValidateNotNullOrWhiteSpace(" "));
		Assert.Equal("The value cannot be an empty string or composed entirely of whitespace. (Parameter 'str')", ex.Message);
	}

	[Fact]
	public void NotThrowArgumentNullExceptionWhenArgumentIsNotNull()
	{
		ThrowIfNullOrWhiteSpaceExample.ValidateNotNullOrWhiteSpace("text");
	}
}