using Xunit;

namespace ABPV1.EntityFrameworkCore;

[CollectionDefinition(ABPV1TestConsts.CollectionDefinitionName)]
public class ABPV1EntityFrameworkCoreCollection : ICollectionFixture<ABPV1EntityFrameworkCoreFixture>
{

}
