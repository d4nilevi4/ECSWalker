using Cysharp.Threading.Tasks;

namespace ECSWalker.Infrastructure
{
    public interface IPayloadState<in TPayload> : IExitableState
    {
        UniTask Enter(TPayload payload);
    }
}