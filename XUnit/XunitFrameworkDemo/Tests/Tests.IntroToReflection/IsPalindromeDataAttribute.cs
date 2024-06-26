using System.Reflection;
using Xunit.Sdk;

namespace Tests.Tests.IntroToReflection;

public class IsPalindromeDataAttribute : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { 121, true };
        yield return new object[] { 12345, false };
        yield return new object[] { 12321, true };
        yield return new object[] { 11, true };
        yield return new object[] { 1, true };
    }
}