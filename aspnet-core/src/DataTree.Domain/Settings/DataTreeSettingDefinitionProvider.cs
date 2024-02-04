using Volo.Abp.Settings;

namespace DataTree.Settings;

public class DataTreeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DataTreeSettings.MySetting1));
    }
}
