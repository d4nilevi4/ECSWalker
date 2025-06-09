using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    public class AlignDirectionToSurfaceSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public AlignDirectionToSurfaceSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DesiredVelocity,
                    GameMatcher.SlideOnSurface,
                    GameMatcher.SurfaceNormal,
                    GameMatcher.Moving));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                Vector3 projectedDirection =
                    Vector3.ProjectOnPlane(
                        entity.DesiredVelocity, 
                        entity.SurfaceNormal.normalized);

                entity.ReplaceDesiredVelocity(projectedDirection);
            }
        }
    }
}