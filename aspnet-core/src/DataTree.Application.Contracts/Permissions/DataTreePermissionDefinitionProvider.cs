using DataTree.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DataTree.Permissions;

public class DataTreePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DataTreePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DataTreePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DataTreeResource>(name);
    }
}
