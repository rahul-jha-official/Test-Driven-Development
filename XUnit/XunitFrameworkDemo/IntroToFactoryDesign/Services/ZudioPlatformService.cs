using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class ZudioPlatformService : IPlatformService
{
    public Platform Platform => Platform.Zudio;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
