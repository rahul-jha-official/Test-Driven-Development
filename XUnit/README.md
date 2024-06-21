# Xunit
xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework. Written by the original inventor of NUnit v2, xUnit.net is the latest technology for unit testing C#, F#, VB.NET and other .NET languages. xUnit.net works with ReSharper, CodeRush, TestDriven.NET and Xamarin. It is part of the .NET Foundation, and operates under their code of conduct. It is licensed under Apache 2 (an OSI approved license).

# Xunit Feature
-	Support multiple platform
-	Support parallel test execution
-	Support data driven tests
-	Is designed to be extensible
-	Easy to install via NuGet Package Manager
-	Is the default unit testing tool in Visual Studio for .Net Core

# Setup XUnit Test Project
-	Create a different project in your solution for writing tests
-	Install xunit using NuGet Package Manager
-	For running test case in Visual Studio you need 'xunit.runner.visualstudio'
-	Also Install Microsoft.NET.Test.Sdk

# Fact vs Theory Attribute 
-	[Fact]
	The Fact attribute is used to mark a method as a test method. It signifies that the method represents a fact that should always be true.
	-	A test marked with the Fact attribute represents a single test case.
	-	If the test method throws an exception or fails an assertion, the test is considered failed.
-	[Theory]
	-	The Theory attribute is used to define a parametrized test. It allows testing multiple inputs against the same test logic.
	-	You provide one or more data sources (via attributes like InlineData, MemberData, etc.) to supply the test with different input values.
	-	Each set of input values is treated as a separate test case.
	-	If any of the test cases fail, the entire theory is considered failed.

In summary, Fact is used for individual test cases, while Theory is used for parameterized tests where the same test logic is applied to multiple sets of inputs.

# Grouping tests in XUnit.Net
-	Multiple tests can be grouped into one category
-	Categories allow us to view and run the test in batches
-	Grouping is done via [Trait] attribute
-	Visual Studio for windows is the best tool to work with Groups
-	Attribute can be applied on class or method.
