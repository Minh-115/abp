using Volo.Abp.Settings;

namespace ABPV1.Settings;

public class ABPV1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPV1Settings.MySetting1));
    }
}
