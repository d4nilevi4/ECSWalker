//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class InputComponentsLookup {

    public const int Destructed = 0;
    public const int CameraRelativeInput = 1;
    public const int Input = 2;
    public const int InputAxis = 3;
    public const int NormalizedRotationInput = 4;
    public const int RawRotationInput = 5;
    public const int WorldInput = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "Destructed",
        "CameraRelativeInput",
        "Input",
        "InputAxis",
        "NormalizedRotationInput",
        "RawRotationInput",
        "WorldInput"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ECSWalker.Common.CommonComponents.Destructed),
        typeof(ECSWalker.Gameplay.Input.CameraRelativeInput),
        typeof(ECSWalker.Gameplay.Input.Input),
        typeof(ECSWalker.Gameplay.Input.InputAxis),
        typeof(ECSWalker.Gameplay.Input.NormalizedRotationInput),
        typeof(ECSWalker.Gameplay.Input.RawRotationInput),
        typeof(ECSWalker.Gameplay.Input.WorldInput)
    };
}
