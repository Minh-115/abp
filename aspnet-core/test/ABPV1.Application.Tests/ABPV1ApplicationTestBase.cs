using Volo.Abp.Modularity;

namespace ABPV1;

public abstract class ABPV1ApplicationTestBase<TStartupModule> : ABPV1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
