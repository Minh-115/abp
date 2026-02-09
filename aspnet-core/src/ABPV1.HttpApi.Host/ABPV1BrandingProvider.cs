using Microsoft.Extensions.Localization;
using ABPV1.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPV1;

[Dependency(ReplaceServices = true)]
public class ABPV1BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ABPV1Resource> _localizer;

    public ABPV1BrandingProvider(IStringLocalizer<ABPV1Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
