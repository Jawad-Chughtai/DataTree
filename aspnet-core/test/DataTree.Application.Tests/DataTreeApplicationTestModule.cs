using Volo.Abp.Modularity;

namespace DataTree;

[DependsOn(
    typeof(DataTreeApplicationModule),
    typeof(DataTreeDomainTestModule)
)]
public class DataTreeApplicationTestModule : AbpModule
{

}
