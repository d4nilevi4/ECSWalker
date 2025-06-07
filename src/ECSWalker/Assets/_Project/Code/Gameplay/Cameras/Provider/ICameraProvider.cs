using UnityEngine;

namespace ECSWalker.Gameplay.Cameras
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        
        void SetMainCamera(Camera camera);
    }
}