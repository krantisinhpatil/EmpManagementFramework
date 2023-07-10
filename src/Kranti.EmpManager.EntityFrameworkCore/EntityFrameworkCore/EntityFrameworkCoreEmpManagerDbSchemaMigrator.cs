using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kranti.EmpManager.Data;
using Volo.Abp.DependencyInjection;

namespace Kranti.EmpManager.EntityFrameworkCore;

public class EntityFrameworkCoreEmpManagerDbSchemaMigrator
    : IEmpManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEmpManagerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EmpManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EmpManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
