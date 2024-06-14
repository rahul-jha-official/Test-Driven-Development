using IntroToXunit.Models;

namespace IntroToXunit;

public class EmployeeInformation
{
    public string GetEmployeeFullName(Employee employee)
    {        
        return string.Concat(employee.FirstName, ' ', employee.LastName);
    }

    public int GetEmployeeAge(Employee employee)
    {
        var currentYear = DateTime.Now.Year;
        var yearOfBirth = employee.DateOfBirth.Year;
        var age = currentYear - yearOfBirth;
        if (employee.DateOfBirth.AddYears(age) > DateOnly.FromDateTime(DateTime.Now))
        {
            age--;
        }
        return age;
    }
}
