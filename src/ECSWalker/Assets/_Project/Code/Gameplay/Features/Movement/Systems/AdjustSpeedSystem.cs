using Entitas;

namespace ECSWalker.Gameplay.Movement
{
    public class AdjustSpeedSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public AdjustSpeedSystem(GameContext game)
        {
            _movables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DesiredVelocity,
                    GameMatcher.Speed,
                    GameMatcher.Moving));
        }

        public void Execute()
        {
            foreach (GameEntity movable in _movables)
            {
                movable.ReplaceDesiredVelocity(movable.DesiredVelocity * movable.Speed);
            }
        }
    }
}