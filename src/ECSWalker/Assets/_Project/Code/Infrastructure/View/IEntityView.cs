using UnityEngine;

namespace ECSWalker.Infrastructure
{
    public interface IEntityView
    {
        GameEntity Entity { get; }
        void SetEntity(GameEntity entity);
        void ReleaseEntity();
        
        GameObject gameObject { get; }
    }
}