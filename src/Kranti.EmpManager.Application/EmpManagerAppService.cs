using System;
using System.Collections.Generic;
using System.Text;
using Kranti.EmpManager.Localization;
using Volo.Abp.Application.Services;

namespace Kranti.EmpManager;

/* Inherit your application services from this class.
 */
public abstract class EmpManagerAppService : ApplicationService
{
    protected EmpManagerAppService()
    {
        LocalizationResource = typeof(EmpManagerResource);
    }
}
