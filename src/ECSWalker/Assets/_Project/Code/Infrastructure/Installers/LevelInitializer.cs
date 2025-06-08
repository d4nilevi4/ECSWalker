using ECSWalker.Gameplay.Cameras;
using UnityEngine;
using Zenject;

namespace ECSWalker.Infrastructure
{
    public class LevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public Transform PlayerSpawnPoint;
        
        private ICameraProvider _cameraProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
        }
    }
}