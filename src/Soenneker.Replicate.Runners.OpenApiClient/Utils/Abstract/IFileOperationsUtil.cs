using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Replicate.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
