using _Project.Code.Gameplay.Features.Movement;
using ECSWalker.Common;
using ECSWalker.Gameplay.GroundDetection;
using ECSWalker.Gameplay.Hero;
using ECSWalker.Gameplay.Input;
using ECSWalker.Gameplay.Rotation;
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
            
            Add(systemFactory.Create<HeroFeature>());
            
            Add(systemFactory.Create<GroundDetectionFeature>());
            Add(systemFactory.Create<MovementFeature>());
            Add(systemFactory.Create<RotationFeature>());
        }
    }
}