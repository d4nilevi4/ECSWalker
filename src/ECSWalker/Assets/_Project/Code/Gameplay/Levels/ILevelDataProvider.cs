using UnityEngine;

namespace ECSWalker.Gameplay.Levels
{
    public interface ILevelDataProvider
    {
        Vector3 PlayerSpawnPoint { get; }
        void SetPlayerSpawnPoint(Vector3 spawnPoint);
    }
}