using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    public class ApplyGravitySystem : IExecuteSystem
    {
        private const float GRAVITY = -9.81f;
        
        private readonly IGroup<GameEntity> _gravityEntities;

        public ApplyGravitySystem(GameContext game)
        {
            _gravityEntities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.AffectedByGravity,
                    GameMatcher.Rigidbody));
        }

        public void Execute()
        {
            foreach (GameEntity e in _gravityEntities)
            {
                Vector3 velocity = e.DesiredVelocity;

                velocity.y = velocity.y + GRAVITY + e.Rigidbody.linearVelocity.x;

                e.ReplaceDesiredVelocity(velocity);
            }
        }
    }
}