namespace Sitecore.Support.DependencyInjection
{
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.DependencyInjection.Extensions;
  using Sitecore.DependencyInjection;

  public class SitecorePerRequestServicesScopeConfigurator : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.Replace(
        new ServiceDescriptor(
          typeof(ISitecoreServiceLocatorScope),
          typeof(SitecorePerRequestServiceScopeRedirection),
          ServiceLifetime.Singleton));
    }
  }
}