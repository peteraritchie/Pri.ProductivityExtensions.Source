namespace Pri.ProductivityExtensions.Source.Examples;

public static class ArrayIndicesExample
{
	public static (string firstIndex, string lastIndex) GetArrayIndicesExample()
	{
		var array = new[] { "A", "B", "C", "D", "E" };
		var firstIndex = array[^array.Length]; // Using hat operator to get the first element
		var lastIndex = array[^1]; // Using hat operator to get the last element
		return (firstIndex, lastIndex);
	}
}