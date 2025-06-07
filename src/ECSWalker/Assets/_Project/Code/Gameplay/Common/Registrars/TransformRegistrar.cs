using ECSWalker.Infrastructure;
using UnityEngine;

namespace ECSWalker.Gameplay
{
    public class TransformRegistrar : EntityComponentRegistrar
    {
        public Transform Transform;
        
        public override void RegisterComponents()
        {
            Entity.AddTransform(Transform);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasTransform)
                Entity.RemoveTransform();
        }
    }
}