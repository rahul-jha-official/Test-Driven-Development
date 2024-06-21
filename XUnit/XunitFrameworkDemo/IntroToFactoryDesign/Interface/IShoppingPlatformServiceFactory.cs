using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Interface;

public interface IShoppingPlatformServiceFactory
{
    IPlatformService GetService(Platform platform);
}
