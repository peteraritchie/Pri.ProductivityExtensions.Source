# Pri.ProductivityExtensions.Source

[![NuGet Version](https://img.shields.io/nuget/v/Pri.ProductivityExtensions.Source)](https://www.nuget.org/packages/Pri.ProductivityExtensions.Source "Current version of Pri.ProductivityExtensions.Source on NuGet")
[![NuGet Downloads](https://img.shields.io/nuget/dt/Pri.ProductivityExtensions.Source)](https://www.nuget.org/packages/Pri.ProductivityExtensions.Source "# of times Pri.ProductivityExtensions.Source has been downloaded from NuGet")
[![GitHub Release](https://img.shields.io/github/v/release/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/releases "The version of the last GitHub release.")
[![CI CD](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/ci.yaml "Status of the last workflow run.")
[![CodeQL](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/github-code-scanning/codeql "Status of the last CodeQL scan.")
[![GitHub License](https://img.shields.io/github/license/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source?tab=MIT-1-ov-file#readme "This project is license under the MIT license.")
[![GitHub Repo stars](https://img.shields.io/github/stars/peteraritchie/Pri.ProductivityExtensions.Source?style=flat)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/stargazers "# of people who have starred this repo.")
[![GitHub Repo forks](https://img.shields.io/github/forks/peteraritchie/Pri.ProductivityExtensions.Source?style=flat)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/forks "# of forks of this repo.")
[![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fapi.codetabs.com%2Fv1%2Floc%2F%3Fgithub%3Dpeteraritchie%2FPri.ProductivityExtensions.Source&query=%24%5B0%5D.linesOfCode.&label=LOC)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)

> [!NOTE]
> An example of a source-only NuGet package from code to deployed NuGet package.
> 
> If you're looking for a source-only package to enable more C# fatures, please
> checkout [Polyfill](https://github.com/SimonCropp/Polyfill).

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
---
[![Repo Size](https://img.shields.io/github/repo-size/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)
[![Languages](https://img.shields.io/github/languages/count/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)
[![Primary Language](https://img.shields.io/github/languages/top/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)
[![Code Size](https://img.shields.io/github/languages/code-size/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)
[![downloads](https://img.shields.io/github/downloads/peteraritchie/Pri.ProductivityExtensions.Source/total)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source)