using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }

    private PlayerInputActions playerInputActions;

    #region Access Self component
    public Animator animator { get; private set; }
    public Rigidbody2D rb { get; private set; }
    #endregion


    #region Player-State
    public Player_IdleState idleState { get; private set; }
    public Player_MoveState moveState { get; private set; }
    #endregion


    public Vector2 inputVector { get; private set; }

    private void Awake() {
        stateMachine = new StateMachine();
        playerInputActions = new PlayerInputActions();

        // Accesss Self component: rigidbody component
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();

        // Create instance of every state
        idleState = new Player_IdleState(this, stateMachine, "Idle");
        moveState = new Player_MoveState(this, stateMachine, "Move");
    }

    private void OnEnable() {
        playerInputActions.Enable();

        // It's for storing value (-1, 1) in inputVector after button has been pressed
        playerInputActions.Player.Move.performed += ctx => inputVector = ctx.ReadValue<Vector2>();
        // It's for clearing stored value after button has been released
        playerInputActions.Player.Move.canceled += ctx => inputVector = ctx.ReadValue<Vector2>();
    }

    private void OnDisable() {
        playerInputActions.Disable();  
    }

    private void Start() {
        stateMachine.Initalize(idleState);
    }


    private void Update() {
        stateMachine.UpdateActiveState();
    }

    public void SetVelocity(float xVelocity, float yVelocity) {
        rb.linearVelocity = new Vector2(xVelocity, yVelocity);
    }

}
