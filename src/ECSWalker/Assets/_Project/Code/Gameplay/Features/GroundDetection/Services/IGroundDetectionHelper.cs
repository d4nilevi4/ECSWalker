using UnityEngine;

namespace ECSWalker.Gameplay.GroundDetection
{
    public interface IGroundDetectionHelper
    {
        bool TryGetRaycastResult(Vector3 origin, out RaycastHit raycastHit);
    }
}