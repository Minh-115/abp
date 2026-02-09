using ABPV1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPV1.Permissions;

public class ABPV1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPV1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPV1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPV1Resource>(name);
    }
}
