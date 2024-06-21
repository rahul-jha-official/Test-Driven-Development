using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class MyntraPlatformService : IPlatformService
{
    public Platform Platform => Platform.Myntra;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
