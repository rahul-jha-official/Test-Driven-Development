using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Interface;

public interface IPlatformService
{
    Platform Platform { get; }
    string GetMessage();
}
