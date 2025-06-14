using System;
using UnityEngine;
using Zenject;

namespace ECSWalker.Gameplay.Input
{
    public class InputProvider : IInputProvider , IInitializable, IDisposable
    {
        private readonly PlayerInputActions _input = new();

        public bool HasAxisInput => GetInputAxis().magnitude >= 0.1f;
        public bool HasRotationInput => GetRawRotationInput().magnitude >= 0.1f;
        
        public void Initialize()
        {
            _input.Enable();
        }

        public Vector2 GetInputAxis() => 
            _input.Movement.InputAxis.ReadValue<Vector2>();
        
        public Vector2 GetRawRotationInput( ) => 
            _input.Movement.Rotation.ReadValue<Vector2>();

        public void Dispose()
        {
            _input.Dispose();
        }
    }
}