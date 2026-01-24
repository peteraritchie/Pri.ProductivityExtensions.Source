using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class ArrayIndicesExampleShould
{
	[Fact]
	public void WorkWithHatOperator()
	{
		var (first, last) = ArrayIndicesExample.GetArrayIndicesExample();
		Assert.Equal("A", first);
		Assert.Equal("E", last);
	}
}

public class ArrayRangeExampleShould
{
	[Fact]
	void WorkWithRangeOperator()
	{
		((int startValue, bool startIsFromEnd), (int endValue, bool endIsFromEnd)) = ArrayRangesExample.GetFirstToSecondLastRangeExample();
		var start = new Index(startValue, startIsFromEnd);
		var end = new Index(endValue, endIsFromEnd);
		Assert.Equal(new Index(1, false), start);
		Assert.Equal(new Index(1, true), end);
	}
}