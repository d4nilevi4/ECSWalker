using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.GroundDetection
{
    public sealed class GroundDetectionFeature : CustomFeature
    {
        public GroundDetectionFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<GroundDetectionSystem>());
            
            Add(systemFactory.Create<GroundDetectionGizmoFeature>());
        }
    }
}