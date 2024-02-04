using DataTree.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DataTree.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DataTreeEntityFrameworkCoreModule),
    typeof(DataTreeApplicationContractsModule)
    )]
public class DataTreeDbMigratorModule : AbpModule
{
}
