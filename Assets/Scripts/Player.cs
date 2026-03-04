using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }

    private EntityState idleState;

    private void Awake() {
        stateMachine = new StateMachine();

        idleState = new EntityState(stateMachine, "Idle");
    }

    private void Start() {
        stateMachine.Initalize(idleState);
    }


    private void Update() {
        stateMachine.UpdateActiveState();
    }



}
