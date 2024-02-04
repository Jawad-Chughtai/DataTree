using DataTree.Samples;
using Xunit;

namespace DataTree.EntityFrameworkCore.Applications;

[Collection(DataTreeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DataTreeEntityFrameworkCoreTestModule>
{

}
