using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Kranti.EmpManager.Web;

[Dependency(ReplaceServices = true)]
public class EmpManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EmpManager";
}
