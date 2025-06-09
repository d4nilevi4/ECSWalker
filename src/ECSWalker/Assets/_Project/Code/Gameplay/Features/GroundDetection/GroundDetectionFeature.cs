using ECSWalker.Common;
using ECSWalker.Gameplay.Movement;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.GroundDetection
{
    public sealed class GroundDetectionFeature : CustomFeature
    {
        public GroundDetectionFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<GroundDetectionSystem>());
            Add(systemFactory.Create<SurfaceDetectionSystem>());
            
            Add(systemFactory.Create<GroundDetectionGizmoFeature>());
        }
    }
}