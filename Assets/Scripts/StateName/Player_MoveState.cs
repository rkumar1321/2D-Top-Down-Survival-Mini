using UnityEngine;

public class Player_MoveState : EntityState {
    public Player_MoveState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName) {
    }


    public override void Update() {
        base.Update();

        if (player.inputVector == Vector2.zero) {
            stateMachine.ChangeState(player.idleState);
        }


        player.SetVelocity(player.inputVector.x, player.inputVector.y);
    }
}
