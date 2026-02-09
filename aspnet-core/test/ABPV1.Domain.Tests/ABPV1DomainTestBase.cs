using Volo.Abp.Modularity;

namespace ABPV1;

/* Inherit from this class for your domain layer tests. */
public abstract class ABPV1DomainTestBase<TStartupModule> : ABPV1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
