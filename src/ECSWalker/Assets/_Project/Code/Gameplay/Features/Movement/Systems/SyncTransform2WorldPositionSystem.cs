using Entitas;

namespace ECSWalker.Gameplay.Movement
{
    public class SyncTransform2WorldPositionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public SyncTransform2WorldPositionSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.MovableByRigidbody,
                    GameMatcher.Rigidbody));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.ReplaceWorldPosition(entity.Rigidbody.position);
            }
        }
    }
}