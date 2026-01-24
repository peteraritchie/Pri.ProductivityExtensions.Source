
namespace Pri.ProductivityExtensions.Source.Examples;

internal static class ArrayRangesExample
{
	/// <remarks>
	/// Can't pass internal types back from this method to code in another
	/// assembly, so we return the components of the Range struct
	/// </remarks>
	public static ((int Value, bool IsFromEnd), (int Value, bool IsFromEnd)) GetFirstToSecondLastRangeExample()
	{
		var range = 1..^1;
		return ((range.Start.Value, range.Start.IsFromEnd), (range.End.Value, range.End.IsFromEnd));
	}

#if false
	/// <remarks>Range operator with indexer doesn't work yet.</remarks>
	public static string[] GetArrayRangeExample()
	{
		// this is not possible because a partial class cannot span multiple
		// assemblies. System.Runtime.CompilerServices.RuntimeHelpers
		// requires a method named "GetSubArray" to be defined to support
		// range operators.
		var array = new[] { "A", "B", "C", "D", "E" };
		var range = array[1..^1]; // Using range operator to get elements from index 1 to the second last element
		return range;
	}
#endif
}
