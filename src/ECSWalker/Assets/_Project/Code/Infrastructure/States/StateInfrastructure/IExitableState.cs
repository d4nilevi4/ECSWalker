using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace ECSWalker.Infrastructure
{
    public interface IExitableState
    {
        [MustUseReturnValue]
        UniTask Exit();
    }
}