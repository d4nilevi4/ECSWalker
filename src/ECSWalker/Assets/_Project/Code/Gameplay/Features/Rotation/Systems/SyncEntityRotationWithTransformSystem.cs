using Entitas;

namespace ECSWalker.Gameplay.Rotation
{
    public class SyncEntityRotationWithTransformSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public SyncEntityRotationWithTransformSystem(GameContext contextParameter)
        {
            _entities = contextParameter.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SyncTransformRotation,
                    GameMatcher.RotationAvailable,
                    GameMatcher.Rotation
                ));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.Transform.rotation = entity.Rotation;
            }
        }
    }
}