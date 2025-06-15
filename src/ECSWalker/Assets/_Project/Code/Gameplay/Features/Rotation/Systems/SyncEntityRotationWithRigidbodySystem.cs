using Entitas;

namespace ECSWalker.Gameplay.Rotation
{
    public class SyncEntityRotationWithRigidbodySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public SyncEntityRotationWithRigidbodySystem(GameContext contextParameter)
        {
            _entities = contextParameter.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SyncRigidbodyRotation,
                    GameMatcher.RotationAvailable,
                    GameMatcher.Rigidbody,
                    GameMatcher.Rotation
                ));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.Rigidbody.MoveRotation(entity.Rotation);
            }
        }
    }
}