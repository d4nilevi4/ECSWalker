﻿using Entitas;
using UnityEngine;

namespace ECSWalker.Gameplay.Input
{
    [Input] public class Input : IComponent { }
    [Input] public class WorldInput : IComponent { }
    [Input] public class CameraRelativeInput : IComponent { }
    [Input] public class RawRotationInput : IComponent { }
    [Input] public class NormalizedRotationInput : IComponent { }
    [Input] public class InputAxis : IComponent { public Vector2 Value; }
}