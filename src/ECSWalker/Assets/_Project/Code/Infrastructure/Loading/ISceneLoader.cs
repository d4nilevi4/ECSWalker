using Cysharp.Threading.Tasks;

namespace ECSWalker.Infrastructure
{
    public interface ISceneLoader
    {
        UniTask LoadSceneAsync(string name);
    }
}