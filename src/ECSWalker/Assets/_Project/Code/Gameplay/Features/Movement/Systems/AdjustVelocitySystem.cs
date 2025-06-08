using Entitas;

namespace ECSWalker.Gameplay.Movement
{
    public class AdjustVelocitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public AdjustVelocitySystem(GameContext game)
        {
            _movables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DesiredVelocity,
                    GameMatcher.MovableByRigidbody,
                    GameMatcher.Rigidbody));
        }

        public void Execute()
        {
            foreach (GameEntity movable in _movables)
            {
                if (movable.isMovementAvailable)
                    movable.Rigidbody.linearVelocity = movable.DesiredVelocity;
            }
        }
    }
}