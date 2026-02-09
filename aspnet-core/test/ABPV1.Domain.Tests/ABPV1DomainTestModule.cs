using Volo.Abp.Modularity;

namespace ABPV1;

[DependsOn(
    typeof(ABPV1DomainModule),
    typeof(ABPV1TestBaseModule)
)]
public class ABPV1DomainTestModule : AbpModule
{

}
