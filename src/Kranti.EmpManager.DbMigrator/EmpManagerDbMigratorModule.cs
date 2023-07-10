using Kranti.EmpManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Kranti.EmpManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmpManagerEntityFrameworkCoreModule),
    typeof(EmpManagerApplicationContractsModule)
    )]
public class EmpManagerDbMigratorModule : AbpModule
{

}
