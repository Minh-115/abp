using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPV1.Data;
using Volo.Abp.DependencyInjection;

namespace ABPV1.EntityFrameworkCore;

public class EntityFrameworkCoreABPV1DbSchemaMigrator
    : IABPV1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABPV1DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ABPV1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABPV1DbContext>()
            .Database
            .MigrateAsync();
    }
}
