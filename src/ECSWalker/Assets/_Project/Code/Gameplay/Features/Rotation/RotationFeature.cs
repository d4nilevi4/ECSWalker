using ECSWalker.Common;
using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.Rotation
{
    public sealed class RotationFeature : CustomFeature
    {
        public RotationFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<SyncEntityRotationWithTransformSystem>());
        }
    }
}