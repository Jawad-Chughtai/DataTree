using DataTree.Samples;
using Xunit;

namespace DataTree.EntityFrameworkCore.Domains;

[Collection(DataTreeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DataTreeEntityFrameworkCoreTestModule>
{

}
