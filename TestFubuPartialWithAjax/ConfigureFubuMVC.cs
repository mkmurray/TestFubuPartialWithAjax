using FubuMVC.Core;
using FubuMVC.Spark;
using TestFubuPartialWithAjax.Handlers.Home;

namespace TestFubuPartialWithAjax
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            IncludeDiagnostics(true);

            Applies.ToThisAssembly();

            ApplyHandlerConventions();

            Routes
                .HomeIs<HomeInputModel>()
                .IgnoreControllerNamesEntirely()
                .IgnoreMethodSuffix("Html")
                .RootAtAssemblyNamespace();

            this.UseSpark();

            Views.TryToAttachWithDefaultConventions();
        }
    }
}