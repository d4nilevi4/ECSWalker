using ECSWalker.Common;
using ECSWalker.Gameplay.Movement;
using ECSWalker.Infrastructure;

namespace _Project.Code.Gameplay.Features.Movement
{
    public sealed class MovementFeature : CustomFeature
    {
        public MovementFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<SetVelocityByDirectionSystem>());
            
            Add(systemFactory.Create<AdjustSpeedSystem>());
            Add(systemFactory.Create<ApplyGravitySystem>());
            
            Add(systemFactory.Create<AdjustVelocitySystem>());
            
            Add(systemFactory.Create<SyncTransform2WorldPositionSystem>());
            Add(systemFactory.Create<SyncWorldPosition2TransformSystem>());
            
            Add(systemFactory.Create<MovementDrawGizmoFeature>());
        }
    }
}