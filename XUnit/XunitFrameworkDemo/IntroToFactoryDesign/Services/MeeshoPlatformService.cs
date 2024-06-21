using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class MeeshoPlatformService : IPlatformService
{
    public Platform Platform => Platform.Meesho;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}

