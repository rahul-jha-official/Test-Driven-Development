using IntroToXunit.Models;

namespace IntroToXunit;

public class PersonInformation
{
    public string GetFullName(Person? employee)
    {
        if (employee is null || string.IsNullOrWhiteSpace(employee.FirstName) || string.IsNullOrWhiteSpace(employee.LastName))
        {
            throw new ArgumentException("FullName cannot be calculated.");
        }
        return string.Concat(employee.FirstName, ' ', employee.LastName);
    }

    public int GetAge(Person employee)
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
