using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.Input
{
    public sealed class InputFeature : CustomFeature
    {
        public InputFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InitializeInputSystem>());
            
            Add(systemFactory.Create<EmitWorldInputSystem>());
            Add(systemFactory.Create<EmitCameraRelativeInputSystem>());
            
            Add(systemFactory.Create<TearDownInputSystem>());
        }
    }
}