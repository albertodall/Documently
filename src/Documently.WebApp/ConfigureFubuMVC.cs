using Documently.WebApp.Handlers;
using FubuMVC.Core;
using FubuMVC.Spark;
using FubuMVC.Diagnostics;

namespace Documently.WebApp
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            // This line turns on the basic diagnostics and request tracing
            Services<DiagnosticServiceRegistry>();

            // Policies
            //Routes.HomeIs<Documently.WebApp.Handlers.Home.GetHandler>(x => x.Execute());
            // Policies
            Routes
                .IgnoreControllerNamesEntirely()
                .IgnoreMethodSuffix("Html")
                .RootAtAssemblyNamespace()
				.HomeIs<Handlers.Home.GetHandler>(x => x.Execute());

            Import<SparkEngine>();
        }
    }
}