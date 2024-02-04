using Xunit;

namespace DataTree.EntityFrameworkCore;

[CollectionDefinition(DataTreeTestConsts.CollectionDefinitionName)]
public class DataTreeEntityFrameworkCoreCollection : ICollectionFixture<DataTreeEntityFrameworkCoreFixture>
{

}
