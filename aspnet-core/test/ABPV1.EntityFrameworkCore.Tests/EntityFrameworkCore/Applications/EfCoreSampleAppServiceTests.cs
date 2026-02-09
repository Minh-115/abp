using ABPV1.Samples;
using Xunit;

namespace ABPV1.EntityFrameworkCore.Applications;

[Collection(ABPV1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABPV1EntityFrameworkCoreTestModule>
{

}
