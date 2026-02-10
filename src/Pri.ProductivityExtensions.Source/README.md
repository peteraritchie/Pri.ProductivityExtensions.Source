# Pri.ProductivityExtensions.Source

Source code to enable modern C# features in .NET Standard 2.0 libraries,

Since .NET Standard 2.0 was created, a variety of C# language features have
been created that leverage/depend on types in the BCL. Including, but
not limited to:
- Ranges and Indices
- `ArgumentException` throw helpers
- `init` only properties
- `[DoesNotReturn]`
- `[NotNullWhen]`
- `Empty` static property for `IReadOnlyCollection<T>` and `IReadOnlyDictionary<TKey, TValue>`.
- `required` modifier indicating that the field or property it applies to must be initialized by an object initializer.

This source-only library, when added to a .NET Standard 2.0 class library,
creates internal versions of the types necessary to enable the above
C# language features.

As a source-, or content-only package, it does not introduce another binary
that needs to be managed or deployed.

## Creating a Library to Use Pri.ProductivityExtensions.Source

```pwsh
dotnet new classlib -o client -f netstandard2.0
```

Add reference to Pri.ProductivityExtensions.Source:

```powershell
dotnet add client package Pri.ProductivityExtensions.Source
```
