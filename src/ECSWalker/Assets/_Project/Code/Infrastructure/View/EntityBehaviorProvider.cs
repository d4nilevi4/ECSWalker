using UnityEngine;

namespace ECSWalker.Infrastructure
{
    public class EntityBehaviorProvider : MonoBehaviour, IEntityBehaviorProvider
    {
        [field: SerializeField] public EntityBehaviour EntityBehaviour { get; private set; }
    }
}