using System.Runtime.CompilerServices;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class CallerArgumentExpressionAttributeExample
{
	// ReSharper disable once EntityNameCapturedOnly.Global
#pragma warning disable IDE0060 // Remove unused parameter
	public static string? GetCallerArgumentExpression(object ? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
#pragma warning restore IDE0060 // Remove unused parameter
	{
		return paramName;
	}
}