using IntroToXunit;
using IntroToXunit.Models;
using Xunit;

namespace Tests.Tests.IntroToXunit;

public class When_Testing_EmployeeInformation
{
    private readonly EmployeeInformation _target;
    public When_Testing_EmployeeInformation()
    {
        _target = new EmployeeInformation();
    }

    [Fact]
    public void And_FirstName_LastName_Are_Joined_With_Space_For_FullName()
    {
        //Arrange
        var employee = GetTestEmployee();

        //Act
        var result = _target.GetEmployeeFullName(employee);

        //Assert
        Assert.NotNull(result);
        Assert.Equal($"{employee.FirstName} {employee.LastName}", result);
    }

    [Fact]
    public void And_Age_Is_Calculated_Correctly()
    {
        //Arrange
        var employee = GetTestEmployee();
        var nearAge = DateTime.Now.Year - employee.DateOfBirth.Year;

        //Act
        var result = _target.GetEmployeeAge(employee);

        //Assert
        Assert.True(result + 1 == nearAge || result == nearAge);
    }

    private static Employee GetTestEmployee()
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
