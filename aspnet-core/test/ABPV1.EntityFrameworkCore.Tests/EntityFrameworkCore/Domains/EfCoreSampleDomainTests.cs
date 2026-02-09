using ABPV1.Samples;
using Xunit;

namespace ABPV1.EntityFrameworkCore.Domains;

[Collection(ABPV1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABPV1EntityFrameworkCoreTestModule>
{

}
