using Kranti.EmpManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kranti.EmpManager.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EmpManagerPageModel : AbpPageModel
{
    protected EmpManagerPageModel()
    {
        LocalizationResourceType = typeof(EmpManagerResource);
    }
}
