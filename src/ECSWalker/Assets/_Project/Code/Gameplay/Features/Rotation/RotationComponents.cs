using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Rotation
{
    [Game] public class RotationAvailable : IComponent { }
    [Game] public class RotationSpeed : IComponent { public float Value; }
    [Game] public class Rotation : IComponent { public Quaternion Value; }
    [Game] public class SyncTransformRotation : IComponent { }
    [Game] public class SyncRigidbodyRotation : IComponent { }
    [Game] public class RotateTowardsVelocity : IComponent { }
    [Game] public class RotateByMouseInput : IComponent { }
}