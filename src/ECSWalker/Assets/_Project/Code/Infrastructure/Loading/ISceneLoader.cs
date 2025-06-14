using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace ECSWalker.Infrastructure
{
    public interface ISceneLoader
    {
        [MustUseReturnValue]
        UniTask LoadSceneAsync(string name);
    }
}