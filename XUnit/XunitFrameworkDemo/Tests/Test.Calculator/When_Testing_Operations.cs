using Calculator;
using Xunit;

namespace Tests.Test.Calculator;

/// <summary>
/// Each test in the test class invoke constructor even if you declare the object in constructor of test class 
/// Here you can use Class Fixture
/// Fixture let you create singleton instance
/// </summary>

public class When_Testing_Operations : IClassFixture<OperationFixture>
{
    private readonly OperationFixture _fixture;
    public When_Testing_Operations(OperationFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData("123","111","234")]
    [InlineData("1","0","1")]
    [InlineData("0","2","2")]    
    [InlineData("0", "0", "0")]
    [InlineData("10000000000000000000000", "10000000000000000000000", "20000000000000000000000")]
    public void And_Add_Operation_Adds_String(string num1, string num2, string expected)
    {
        //Act
        var actual = _fixture.Target.Add(num1, num2);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData("1", "")]
    [InlineData("", "1")]
    public void And_Add_Operation_Throws_Exception_If_Invalid_Input_Provided(string num1, string num2)
    {
        //Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => _fixture.Target.Add(num1,num2));

        Assert.NotNull(exception);
        Assert.Equal("Arguments Provided Are Not Valid.", exception.Message);
    }
}

public class OperationFixture
{
    public IOperations Target = new Operations();
}