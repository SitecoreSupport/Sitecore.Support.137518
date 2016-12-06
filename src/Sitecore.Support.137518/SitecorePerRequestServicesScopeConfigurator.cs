using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sitecore.DependencyInjection;
using System;

namespace Sitecore.Support.DependencyInjection
{
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