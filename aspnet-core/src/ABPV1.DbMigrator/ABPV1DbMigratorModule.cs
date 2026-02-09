using ABPV1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABPV1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPV1EntityFrameworkCoreModule),
    typeof(ABPV1ApplicationContractsModule)
    )]
public class ABPV1DbMigratorModule : AbpModule
{
}
