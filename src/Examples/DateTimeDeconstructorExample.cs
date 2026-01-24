using System;

namespace Pri.ProductivityExtensions.Source.Examples;

public static class DateTimeDeconstructorExample
{
	public static (int year, int month, int day) DeconstructDateTimeExample()
	{
		var dateTime = new DateTime(2024, 6, 15);
		var (year, month, day) = dateTime;
		return (year, month, day);
	}
}