using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class FirstCryPlatformService : IPlatformService
{
    public Platform Platform => Platform.FirstCry;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
