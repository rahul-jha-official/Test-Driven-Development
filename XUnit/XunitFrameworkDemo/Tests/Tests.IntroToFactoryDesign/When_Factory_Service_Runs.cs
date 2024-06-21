using IntroToFactoryDesign.Interface;
using IntroToFactoryDesign.Models;
using IntroToFactoryDesign.Services;
using System.Reflection;
using Xunit;

namespace Tests.Tests.IntroToFactoryDesign;

public class When_Factory_Service_Runs
{
    [Theory]
    [InlineData(Platform.None, typeof(DefaultPlatformService))]
    [InlineData(Platform.Ajio, typeof(AjioPlatformService))]
    [InlineData(Platform.Amazon, typeof(AmazonPlatformService))]
    [InlineData(Platform.FirstCry, typeof(FirstCryPlatformService))]
    [InlineData(Platform.Flipkart, typeof(FlipkartPlatformService))]
    [InlineData(Platform.Meesho, typeof(MeeshoPlatformService))]
    [InlineData(Platform.Myntra, typeof(MyntraPlatformService))]
    [InlineData(Platform.Zudio, typeof(ZudioPlatformService))]
    public void ShoppingPlatformServiceFactory_Tested(Platform platform, Type serviceType)
    {
        //Arrange
        var services = GetListOfServicesInheritingInterface<IPlatformService>("IntroToFactoryDesign");
        var factory = new ShoppingPlatformServiceFactory(services);

        //Act
        var service = factory.GetService(platform);

        //Assert
        Assert.IsType(serviceType, service);
    }

    /// <summary>
    /// If your service accept some parameters then you can pass null for every parameter
    /// Ex. services.Add((T)Activator.CreateInstance(type, new object[type.GetConstructors().First().GetParameters().Length]));
    /// In my case no parameter are required.
    /// </summary>
    private static List<T> GetListOfServicesInheritingInterface<T>(string project)
    {
        var allTypes = Assembly.Load(project).GetTypes();
        var @interface = typeof(T);
        var services = new List<T>();

        foreach (var type in allTypes)
        {
            if (@interface.IsAssignableFrom(type) && type.IsClass && !type.IsAbstract)
            {
                services.Add((T)Activator.CreateInstance(type));
            }
        }
        return services;
    }
}
