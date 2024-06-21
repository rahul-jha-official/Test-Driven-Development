using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class FlipkartPlatformService : IPlatformService
{
    public Platform Platform => Platform.Flipkart;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
