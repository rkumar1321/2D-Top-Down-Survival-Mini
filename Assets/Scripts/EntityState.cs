using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class EntityState {
    protected Player player;
    protected StateMachine stateMachine;
    protected string animBoolName;

    private Animator anim;

    public EntityState(Player player, StateMachine stateMachine, string stateName) {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = stateName;


        anim = player.animator;
    }

    public virtual void Enter() {
        anim.SetBool(animBoolName, true);
    }

    public virtual void Update() {
        Logger.Log($"Update: {animBoolName}");
    }

    public virtual void Exit() {
        anim.SetBool(animBoolName, false);
    }
}
