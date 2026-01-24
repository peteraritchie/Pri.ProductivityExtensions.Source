namespace Pri.ProductivityExtensions.Source.Examples;

public static class NotNullWhenExample
{
	public static bool IsNotNull<T>(T? value, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? notNullValue)
		where T : class
	{
		if (value is not null)
		{
			notNullValue = value;
			return true;
		}
		notNullValue = null;
		return false;
	}
}