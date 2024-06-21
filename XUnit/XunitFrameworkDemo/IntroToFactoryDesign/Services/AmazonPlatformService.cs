using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class AmazonPlatformService : IPlatformService
{
    public Platform Platform => Platform.Amazon;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
