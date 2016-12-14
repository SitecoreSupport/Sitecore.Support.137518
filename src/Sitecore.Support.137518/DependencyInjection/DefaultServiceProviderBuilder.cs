namespace Sitecore.Support.DependencyInjection
{
  using System.Collections.Generic;
  using Sitecore.DependencyInjection;

  public class DefaultServiceProviderBuilder : DefaultBaseServiceProviderBuilder
  {
    [UsedImplicitly]
    public DefaultServiceProviderBuilder()
    {
    }

    public override IEnumerable<IServicesConfigurator> GetServicesConfigurators()
    {
      foreach (var configurator in base.GetServicesConfigurators())
      {
        yield return configurator;
      }

      yield return new Sitecore.Support.DependencyInjection.SitecorePerRequestServicesScopeConfigurator();
    }
  }
}