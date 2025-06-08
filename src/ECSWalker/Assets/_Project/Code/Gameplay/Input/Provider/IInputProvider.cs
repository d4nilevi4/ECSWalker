using UnityEngine;

namespace ECSWalker.Gameplay.Input
{
    public interface IInputProvider
    {
        bool HasAxisInput { get; }
        Vector2 GetInputAxis();
    }
}