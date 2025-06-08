using ECSWalker.Common;
using ECSWalker.Common.Entity;
using Entitas;

namespace ECSWalker.Gameplay.Input
{
    public class InitializeInputSystem : IInitializeSystem
    {
        public void Initialize()
        {
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isWorldInput = true);
            
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isCameraRelativeInput = true);
        }
    }
}