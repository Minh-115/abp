using System;
using System.Collections.Generic;
using System.Text;
using ABPV1.Localization;
using Volo.Abp.Application.Services;

namespace ABPV1;

/* Inherit your application services from this class.
 */
public abstract class ABPV1AppService : ApplicationService
{
    protected ABPV1AppService()
    {
        LocalizationResource = typeof(ABPV1Resource);
    }
}
public class TestAppService : ApplicationService
{
    public string Hello() => "Hi";
}
