using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay
{
    public class BattleFeature : CustomFeature
    {
        public BattleFeature(
            ISystemFactory systemFactory
        )
        {
            Add(systemFactory.Create<BindViewFeature>());
        }
    }
}