using UnityEngine;

namespace ECSWalker.Gameplay.Input
{
    public interface IInputProvider
    {
        bool HasAxisInput { get; }
        bool HasRotationInput { get; }
        Vector2 GetInputAxis();
        Vector2 GetRawRotationInput( );
    }
}