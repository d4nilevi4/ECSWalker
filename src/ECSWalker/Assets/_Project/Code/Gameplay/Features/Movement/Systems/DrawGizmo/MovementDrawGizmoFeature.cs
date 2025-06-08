using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.Movement
{
    public sealed class MovementDrawGizmoFeature : CustomFeature
    {
        public MovementDrawGizmoFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<DrawVelocityGizmoSystem>());
        }
    }
}