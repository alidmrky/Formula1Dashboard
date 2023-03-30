using Formula1Dashboard.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Formula1Dashboard.Permissions;

public class Formula1DashboardPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Formula1DashboardPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Formula1DashboardPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Formula1DashboardResource>(name);
    }
}
