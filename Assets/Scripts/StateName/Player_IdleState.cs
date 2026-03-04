using UnityEngine;

public class Player_IdleState : EntityState {
    public Player_IdleState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName) {
    }


    public override void Update() {
        base.Update();

        if (player.inputVector != Vector2.zero) {
            stateMachine.ChangeState(player.moveState);
        }

    }
}
