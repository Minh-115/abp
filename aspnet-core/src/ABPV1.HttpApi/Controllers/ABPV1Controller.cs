using ABPV1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPV1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPV1Controller : AbpControllerBase
{
    protected ABPV1Controller()
    {
        LocalizationResource = typeof(ABPV1Resource);
    }
}
