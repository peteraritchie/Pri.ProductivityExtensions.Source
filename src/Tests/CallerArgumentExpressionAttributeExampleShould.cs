using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class CallerArgumentExpressionAttributeExampleShould
{
	[Fact]
	public void ReturnCorrectParameterName()
	{
		// Arrange
		object? testArgument = null;
		// Act
		string? paramName = CallerArgumentExpressionAttributeExample.GetCallerArgumentExpression(testArgument);
		// Assert
		Assert.Equal(nameof(testArgument), paramName);
	}
}