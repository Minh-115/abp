using System.Threading.Tasks;

namespace ABPV1.Data;

public interface IABPV1DbSchemaMigrator
{
    Task MigrateAsync();
}
