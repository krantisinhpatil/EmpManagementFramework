using Volo.Abp.Modularity;

namespace Kranti.EmpManager;

[DependsOn(
    typeof(EmpManagerApplicationModule),
    typeof(EmpManagerDomainTestModule)
    )]
public class EmpManagerApplicationTestModule : AbpModule
{

}
