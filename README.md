# Pri.ProductivityExtensions.Source

[![NuGet Version](https://img.shields.io/nuget/v/Pri.ProductivityExtensions.Source)](https://www.nuget.org/packages/Pri.ProductivityExtensions.Source)
[![GitHub Release](https://img.shields.io/github/v/release/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/releases)
[![CI CD](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/ci.yaml)
[![CodeQL](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/actions/workflows/github-code-scanning/codeql)
[![GitHub License](https://img.shields.io/github/license/peteraritchie/Pri.ProductivityExtensions.Source)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source?tab=MIT-1-ov-file#readme)
[![GitHub Repo stars](https://img.shields.io/github/stars/peteraritchie/Pri.ProductivityExtensions.Source?style=flat)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/stargazers)
[![GitHub Repo forks](https://img.shields.io/github/forks/peteraritchie/Pri.ProductivityExtensions.Source?style=flat)](https://github.com/peteraritchie/Pri.ProductivityExtensions.Source/forks)

Source code to enable modern C# features in .NET Standard 2.0 libraries     

Since .NET Standard 2.0 was created a variety of C# language features have
been created that leverage/depend on types in in the BCL. Including, but
not limited to:
- Ranges and Indices
- ArgumentException throw helpers
- [DoesNotReturn]
- [NotNullWhen]

This source-only library, when added to a .NET Standard 2.0 class library,
creates internal versions of the types necessary to enable the above
C# language features.

As a source-, or content-only package it does not introduce another binary
that needs to be managed or deployed.

## Creating a Library to Use Pri.ProductivityExtensions.Source

```pwsh
dotnet new classlib -o client -f netstandard2.0
```

Add reference to Pri.ProductivityExtensions.Source:

```powershell
dotnet add client package Pri.ProductivityExtensions.Source
```
