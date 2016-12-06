using Sitecore.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sitecore.Support.DependencyInjection
{
    public class DefaultServiceProviderBuilder : DefaultBaseServiceProviderBuilder
    {
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