using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace ECSWalker.Infrastructure
{
    public interface IState : IExitableState
    {
        [MustUseReturnValue]
        UniTask Enter();
    }
}