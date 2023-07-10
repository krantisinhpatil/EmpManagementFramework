using Kranti.EmpManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kranti.EmpManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmpManagerController : AbpControllerBase
{
    protected EmpManagerController()
    {
        LocalizationResource = typeof(EmpManagerResource);
    }
}
