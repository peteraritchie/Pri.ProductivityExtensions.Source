using Pri.ProductivityExtensions.Source.Examples;

namespace Pri.ProductivityExtensions.Tests;

public class CollectionsExtensionsShould
{
	[Fact]
	void CreateEmptyReadOnlyDictionary()
	{
		var sut = EmptyReadOnlyDictionaryExample.GetReadOnlyDictionary<int, string>();
		Assert.NotNull(sut);
		Assert.Empty(sut);
	}

	[Fact]
	void CreateEmptyReadOnlyCollection()
	{
		var sut = EmptyReadOnlyCollectionExample.GetReadOnlyCollection<string>();
		Assert.NotNull(sut);
		Assert.Empty(sut);
	}
}