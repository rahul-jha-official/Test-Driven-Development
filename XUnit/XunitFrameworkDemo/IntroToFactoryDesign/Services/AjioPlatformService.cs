using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class AjioPlatformService : IPlatformService
{
    public Platform Platform => Platform.Ajio;

    public string GetMessage()
    {
        return $"Welcome to {Platform}";
    }
}
