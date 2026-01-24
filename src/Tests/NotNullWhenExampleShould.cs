using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class NotNullWhenExampleShould
{
	[Fact]
	public void ReturnTrueWhenValueIsNotNull()
	{
		// Arrange
		string? testValue = "Hello, World!";
		// Act
		bool result = NotNullWhenExample.IsNotNull(testValue, out string? notNullValue);
		// Assert
		Assert.True(result);
		Assert.Equal(testValue, notNullValue);
	}

	[Fact]
	public void ReturnFalseWhenValueIsNull()
	{
		// Arrange
		string? testValue = null;
		// Act
		bool result = NotNullWhenExample.IsNotNull(testValue, out string? notNullValue);
		// Assert
		Assert.False(result);
		Assert.Null(notNullValue);
	}
}