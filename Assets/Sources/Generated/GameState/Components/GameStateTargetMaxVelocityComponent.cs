//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity targetMaxVelocityEntity { get { return GetGroup(GameStateMatcher.TargetMaxVelocity).GetSingleEntity(); } }
    public TargetMaxVelocityComponent targetMaxVelocity { get { return targetMaxVelocityEntity.targetMaxVelocity; } }
    public bool hasTargetMaxVelocity { get { return targetMaxVelocityEntity != null; } }

    public GameStateEntity SetTargetMaxVelocity(UnityEngine.Vector2 newValue) {
        if (hasTargetMaxVelocity) {
            throw new Entitas.EntitasException("Could not set TargetMaxVelocity!\n" + this + " already has an entity with TargetMaxVelocityComponent!",
                "You should check if the context already has a targetMaxVelocityEntity before setting it or use context.ReplaceTargetMaxVelocity().");
        }
        var entity = CreateEntity();
        entity.AddTargetMaxVelocity(newValue);
        return entity;
    }

    public void ReplaceTargetMaxVelocity(UnityEngine.Vector2 newValue) {
        var entity = targetMaxVelocityEntity;
        if (entity == null) {
            entity = SetTargetMaxVelocity(newValue);
        } else {
            entity.ReplaceTargetMaxVelocity(newValue);
        }
    }

    public void RemoveTargetMaxVelocity() {
        targetMaxVelocityEntity.Destroy();
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
public partial class GameStateEntity {

    public TargetMaxVelocityComponent targetMaxVelocity { get { return (TargetMaxVelocityComponent)GetComponent(GameStateComponentsLookup.TargetMaxVelocity); } }
    public bool hasTargetMaxVelocity { get { return HasComponent(GameStateComponentsLookup.TargetMaxVelocity); } }

    public void AddTargetMaxVelocity(UnityEngine.Vector2 newValue) {
        var index = GameStateComponentsLookup.TargetMaxVelocity;
        var component = CreateComponent<TargetMaxVelocityComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTargetMaxVelocity(UnityEngine.Vector2 newValue) {
        var index = GameStateComponentsLookup.TargetMaxVelocity;
        var component = CreateComponent<TargetMaxVelocityComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTargetMaxVelocity() {
        RemoveComponent(GameStateComponentsLookup.TargetMaxVelocity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherTargetMaxVelocity;

    public static Entitas.IMatcher<GameStateEntity> TargetMaxVelocity {
        get {
            if (_matcherTargetMaxVelocity == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.TargetMaxVelocity);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherTargetMaxVelocity = matcher;
            }

            return _matcherTargetMaxVelocity;
        }
    }
}