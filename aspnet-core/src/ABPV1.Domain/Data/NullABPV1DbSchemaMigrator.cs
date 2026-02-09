using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPV1.Data;

/* This is used if database provider does't define
 * IABPV1DbSchemaMigrator implementation.
 */
public class NullABPV1DbSchemaMigrator : IABPV1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
