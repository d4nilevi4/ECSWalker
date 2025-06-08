using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    [Game] public class RigidbodyComponent : IComponent { public Rigidbody Value; }
    [Game] public class MovableByRigidbody : IComponent { }
    [Game] public class Speed : IComponent { public float Value; }
    [Game] public class DesiredVelocity : IComponent { public Vector3 Value; }
    [Game] public class Direction : IComponent { public Vector3 Value; }
    [Game] public class Moving : IComponent { }
    [Game] public class MovementAvailable : IComponent { }
    [Game] public class SlideOnSurface : IComponent { }
    [Game] public class AffectedByGravity : IComponent { }
    [Game] public class SyncTransformPosition : IComponent { }
}