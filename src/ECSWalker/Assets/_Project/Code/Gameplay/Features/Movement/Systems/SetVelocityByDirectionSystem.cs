using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    public class SetVelocityByDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public SetVelocityByDirectionSystem(GameContext game)
        {
            _movables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.MovableByRigidbody,
                    GameMatcher.DesiredVelocity,
                    GameMatcher.Direction
                ));
        }

        public void Execute()
        {
            foreach (GameEntity movable in _movables)
            {
                if(movable.isMoving)
                    movable.ReplaceDesiredVelocity(movable.Direction);
                else
                    movable.ReplaceDesiredVelocity(Vector3.zero);
            }
        }
    }
}