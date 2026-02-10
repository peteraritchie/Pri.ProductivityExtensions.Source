using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class RequiredPropertyShould
{
	[Fact]
	void AllowInitializingRequiredMembers()
	{
		_ = new RequiredPropertyExample
		{
			Value = 1
		};
	}
}