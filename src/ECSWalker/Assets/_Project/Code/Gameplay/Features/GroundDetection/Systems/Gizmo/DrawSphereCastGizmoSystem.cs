using ECSWalker.Common;
using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.GroundDetection
{
    public class DrawSphereCastGizmoSystem : IDrawGizmoSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public DrawSphereCastGizmoSystem(GameContext contextParameter)
        {
            _entities = contextParameter.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.AffectedByGravity));
        }

        public void DrawGizmo()
        {
            foreach (GameEntity entity in _entities)
            {
                Gizmos.DrawWireSphere(entity.WorldPosition + Vector3.up * .15f, .2f);
            }
        }
    }
}