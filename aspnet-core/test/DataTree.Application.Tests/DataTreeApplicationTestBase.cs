using Volo.Abp.Modularity;

namespace DataTree;

public abstract class DataTreeApplicationTestBase<TStartupModule> : DataTreeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
