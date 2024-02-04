using Volo.Abp.Modularity;

namespace DataTree;

/* Inherit from this class for your domain layer tests. */
public abstract class DataTreeDomainTestBase<TStartupModule> : DataTreeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
