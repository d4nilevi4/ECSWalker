using ECSWalker.Common;
using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Movement
{
    public class DrawVelocityGizmoSystem : IDrawGizmoSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public DrawVelocityGizmoSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.DesiredVelocity,
                    GameMatcher.MovementAvailable));
        }

        public void DrawGizmo()
        {
            foreach (GameEntity entity in _entities)
            {
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(
                    entity.WorldPosition, 
                    entity.WorldPosition + entity.DesiredVelocity.normalized);
                Gizmos.color = Color.white;
            }
        }
    }
}