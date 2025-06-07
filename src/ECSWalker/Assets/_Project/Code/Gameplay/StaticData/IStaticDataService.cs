using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace ECSWalker.Gameplay.StaticData
{
    public interface IStaticDataService
    {
        [MustUseReturnValue]
        UniTask LoadAll();
    }
}