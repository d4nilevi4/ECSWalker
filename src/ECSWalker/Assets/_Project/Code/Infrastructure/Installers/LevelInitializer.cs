using ECSWalker.Gameplay.Cameras;
using ECSWalker.Gameplay.Levels;
using UnityEngine;
using Zenject;

namespace ECSWalker.Infrastructure
{
    public class LevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public Transform PlayerSpawnPoint;
        
        private ICameraProvider _cameraProvider;
        private ILevelDataProvider _levelDataProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider,
            ILevelDataProvider levelDataProvider
            )
        {
            _levelDataProvider = levelDataProvider;
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
            _levelDataProvider.SetPlayerSpawnPoint(PlayerSpawnPoint.position);
        }
    }
}