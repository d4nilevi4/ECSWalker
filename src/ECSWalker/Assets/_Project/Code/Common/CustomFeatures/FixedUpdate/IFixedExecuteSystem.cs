using Entitas;

namespace ECSWalker.Common
{
    public interface IFixedExecuteSystem : ISystem
    {
        void FixedExecute();
    }
}