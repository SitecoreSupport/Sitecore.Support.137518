using Sitecore.DependencyInjection;
using System;

namespace Sitecore.Support.DependencyInjection
{
    public class SitecorePerRequestServiceScopeRedirection : ISitecoreServiceLocatorScope
    {
        IServiceProvider _applicationServiceProvider;

        public SitecorePerRequestServiceScopeRedirection(IServiceProvider applicationServiceProvider)
        {
            _applicationServiceProvider = applicationServiceProvider;
        }

        public IServiceProvider ServiceProvider
        {
            get
            {
                var scope = SitecorePerRequestScopeModule.GetScope(_applicationServiceProvider);
                return scope != null ? scope.ServiceProvider : _applicationServiceProvider;
            }
        }

        public void Dispose()
        {
        }
    }
}