using ECSWalker.Common;
using ECSWalker.Gameplay.Input;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay
{
    public class BattleFeature : CustomFeature
    {
        public BattleFeature(
            ISystemFactory systemFactory
        )
        {
            Add(systemFactory.Create<InputFeature>());
            
            Add(systemFactory.Create<BindViewFeature>());
        }
    }
}