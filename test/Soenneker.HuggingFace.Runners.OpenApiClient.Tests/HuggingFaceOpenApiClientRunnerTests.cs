using Soenneker.Tests.HostedUnit;

namespace Soenneker.HuggingFace.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class HuggingFaceOpenApiClientRunnerTests : HostedUnitTest
{
    public HuggingFaceOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
