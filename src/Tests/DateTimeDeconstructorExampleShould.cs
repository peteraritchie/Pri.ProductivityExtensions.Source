using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class DateTimeDeconstructorExampleShould
{
	[Fact]
	public void DeconstructCorrectly()
	{
		(int year, int month, int day) = DateTimeDeconstructorExample.DeconstructDateTimeExample();

		Assert.Equal(2024, year);
		Assert.Equal(6, month);
		Assert.Equal(15, day);
	}
}