using IntroToXunit;
using IntroToXunit.Models;
using Xunit;

namespace Tests.Tests.IntroToXunit;

public class When_Testing_Person_Information
{
    private readonly PersonInformation _target;
    public When_Testing_Person_Information()
    {
        _target = new PersonInformation();
    }

    [Fact]
    public void And_If_Person_Is_Employee_Then_Id_Is_Present()
    {
        //Arrange & Act
        Person person = GetTestEmployee();
        
        //Assert
        var employee = Assert.IsType<Employee>(person);
        Assert.NotNull(employee);
        Assert.Equal(1, employee.Id);
    }

    [Theory]
    [InlineData("", "Gupta", false)]
    [InlineData("Nakun", "", false)]
    [InlineData("", "", true)]
    public void And_Employee_Data_Is_Not_Present_Exception_Thrown(string firstName, string lastName, bool isEmployeeObhectNull)
    {
        Employee? e = null;
        if (!isEmployeeObhectNull)
        {
            e = new Employee
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        var exception = Assert.Throws<ArgumentException>(() => _target.GetFullName(e));

        Assert.Equal("fullname cannot be calculated.", exception.Message, ignoreCase: true);
    }

    [Fact]
    public void And_FirstName_LastName_Are_Joined_With_Space_For_FullName()
    {
        //Arrange
        var employee = GetTestEmployee();

        //Act
        var result = _target.GetFullName(employee);

        //Assert
        Assert.NotNull(result);
        Assert.False(string.IsNullOrWhiteSpace(result));
        Assert.Equal($"{employee.FirstName} {employee.LastName}", result);
    }

    [Fact]
    public void And_Age_Is_Calculated_Correctly()
    {
        //Arrange
        var employee = GetTestEmployee();
        var nearAge = DateTime.Now.Year - employee.DateOfBirth.Year;

        //Act
        var result = _target.GetAge(employee);

        //Assert
        Assert.True(result + 1 == nearAge || result == nearAge);
    }

    private static Person GetTestEmployee()
    {
        return new Employee
        {
            Id = 1,
            FirstName = "Priyansh",
            LastName = "Chaturvedi",
            DateOfBirth = new DateOnly(1996, 8, 7)
        };
    }
}
