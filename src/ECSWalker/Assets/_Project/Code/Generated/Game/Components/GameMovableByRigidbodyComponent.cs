//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMovableByRigidbody;

    public static Entitas.IMatcher<GameEntity> MovableByRigidbody {
        get {
            if (_matcherMovableByRigidbody == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovableByRigidbody);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovableByRigidbody = matcher;
            }

            return _matcherMovableByRigidbody;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly ECSWalker.Gameplay.Movement.MovableByRigidbody movableByRigidbodyComponent = new ECSWalker.Gameplay.Movement.MovableByRigidbody();

    public bool isMovableByRigidbody {
        get { return HasComponent(GameComponentsLookup.MovableByRigidbody); }
        set {
            if (value != isMovableByRigidbody) {
                var index = GameComponentsLookup.MovableByRigidbody;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : movableByRigidbodyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
