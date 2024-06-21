using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class DefaultPlatformService : IPlatformService
{
    public Platform Platform => Platform.None;

    public string GetMessage()
    {
        return "Not an actual service";
    }
}
