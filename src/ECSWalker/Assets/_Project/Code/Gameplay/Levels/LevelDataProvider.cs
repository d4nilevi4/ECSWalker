using UnityEngine;

namespace ECSWalker.Gameplay.Levels
{
    public class LevelDataProvider : ILevelDataProvider
    {
        public Vector3 PlayerSpawnPoint { get; private set; }
        public void SetPlayerSpawnPoint(Vector3 spawnPoint)
        {
            PlayerSpawnPoint = spawnPoint;
        }
    }
}