using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DataTree;

[Dependency(ReplaceServices = true)]
public class DataTreeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DataTree";
}
