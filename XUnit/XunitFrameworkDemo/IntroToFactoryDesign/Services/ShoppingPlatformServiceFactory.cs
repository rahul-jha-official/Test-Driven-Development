using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;

namespace IntroToFactoryDesign.Services;

public class ShoppingPlatformServiceFactory : IShoppingPlatformServiceFactory
{
    private readonly IEnumerable<IPlatformService> _services;
    private readonly IPlatformService _defaultServices;
    public ShoppingPlatformServiceFactory(IEnumerable<IPlatformService> services)
    {
        _services = services;
        _defaultServices = new DefaultPlatformService();
    }
    public IPlatformService GetService(Platform platform)
    {
        var service = _services.FirstOrDefault(x => x.Platform == platform);
        return service ?? _defaultServices;
    }
}
