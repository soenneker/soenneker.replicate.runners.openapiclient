using Soenneker.Tests.HostedUnit;

namespace Soenneker.Replicate.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ReplicateOpenApiClientRunnerTests : HostedUnitTest
{
    public ReplicateOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
