using IntroToReflection;
using System.Reflection;
using Xunit;

namespace Tests.Tests.IntroToReflection;


/// <summary>
/// Its not recomended to test private method.
/// If we test the public methods the private methods get tested internally as well. If you are testing private methods of a class that means there is something seriously wrong with the class design.
/// But we can test private method though testing private method is not recomended.
/// 
/// One more non recomended thing, if the class you are testing having private constructor 
/// Use: Activator.CreateInstance(numberTheoryClass, true) to create instance
/// </summary>
public class When_Number_Theory_Class_Runs
{
    [Theory]
    [IsPalindromeDataAttribute]
    public void And_Is_Palindrome_Function_Is_Tested(int n, bool expected)
    {
        //Arrange
        var numberTheoryClass = typeof(NumberTheory);
        var isPalindromeMethod = numberTheoryClass.GetTypeInfo().GetDeclaredMethod("IsPalindrome");
        
        //Act
        var actual = isPalindromeMethod.Invoke(Activator.CreateInstance(numberTheoryClass), [n]);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}
