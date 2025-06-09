using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.GroundDetection
{
    public sealed class GroundDetectionGizmoFeature : CustomFeature
    {
        public GroundDetectionGizmoFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<DrawSphereCastGizmoSystem>());
            Add(systemFactory.Create<DrawGroundNormalGizmoSystem>());
        }
    }
}