using ECSWalker.Infrastructure;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    public class RigidbodyRegistrar : EntityComponentRegistrar
    {
        public Rigidbody Rigidbody;

        private void Awake()
        {
            Rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        }

        public override void RegisterComponents()
        {
            Entity.AddRigidbody(Rigidbody);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasRigidbody)
                Entity.RemoveRigidbody();
        }
    }
}