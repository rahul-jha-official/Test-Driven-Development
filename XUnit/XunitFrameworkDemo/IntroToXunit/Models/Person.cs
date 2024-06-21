namespace IntroToXunit.Models;

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string GovernmentId { get; set; } = string.Empty;
}
