using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EntityState {
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(StateMachine stateMachine, string stateName) {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter() {
        Logger.Log($"Enter: {stateName}");
    }

    public virtual void Update() {
        Logger.Log($"Update: {stateName}");
    }

    public virtual void Exit() {
        Logger.Log($"Exit: {stateName}");
    }
}
