using Volo.Abp.Modularity;

namespace ABPV1;

[DependsOn(
    typeof(ABPV1ApplicationModule),
    typeof(ABPV1DomainTestModule)
)]
public class ABPV1ApplicationTestModule : AbpModule
{

}
