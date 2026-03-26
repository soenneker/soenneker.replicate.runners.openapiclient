using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Replicate.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ReplicateOpenApiClientRunnerTests : FixturedUnitTest
{
    public ReplicateOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
