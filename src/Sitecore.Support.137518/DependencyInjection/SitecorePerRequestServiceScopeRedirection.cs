namespace Sitecore.Support.DependencyInjection
{
  using System;
  using Sitecore.DependencyInjection;

  public class SitecorePerRequestServiceScopeRedirection : ISitecoreServiceLocatorScope
  {
    private readonly IServiceProvider _ApplicationServiceProvider;

    public SitecorePerRequestServiceScopeRedirection(IServiceProvider applicationServiceProvider)
    {
      _ApplicationServiceProvider = applicationServiceProvider;
    }

    public IServiceProvider ServiceProvider
    {
      get
      {
        var scope = SitecorePerRequestScopeModule.GetScope(_ApplicationServiceProvider);
        var serviceProvider = scope != null ? scope.ServiceProvider : _ApplicationServiceProvider;

        return serviceProvider;
      }
    }

    public void Dispose()
    {
    }
  }
}