using Kranti.EmpManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kranti.EmpManager;

[DependsOn(
    typeof(EmpManagerEntityFrameworkCoreTestModule)
    )]
public class EmpManagerDomainTestModule : AbpModule
{

}
