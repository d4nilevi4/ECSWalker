using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.Hero
{
    public sealed class HeroFeature : CustomFeature
    {
        public HeroFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<SetHeroDirectionByInputSystem>());
        }
    }
}