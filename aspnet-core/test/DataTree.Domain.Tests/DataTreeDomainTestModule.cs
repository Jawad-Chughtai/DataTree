using Volo.Abp.Modularity;

namespace DataTree;

[DependsOn(
    typeof(DataTreeDomainModule),
    typeof(DataTreeTestBaseModule)
)]
public class DataTreeDomainTestModule : AbpModule
{

}
