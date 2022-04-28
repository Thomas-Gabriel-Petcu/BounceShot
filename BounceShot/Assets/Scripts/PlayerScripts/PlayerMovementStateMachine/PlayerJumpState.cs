using UnityEngine;

public class PlayerJumpState : BaseState
{
    private GameObject _player;
    private Rigidbody2D playerRB2D;

    private float jumpForce;
    public PlayerJumpState(PlayerMovementFSM pmfsm, float jumpForce, GameObject player) : base("PlayerJumpState", pmfsm)
    {
        this.jumpForce = jumpForce;
        _player = player;
        playerRB2D = player.GetComponent<Rigidbody2D>();
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        playerRB2D.AddForce(new Vector2(0, jumpForce));
    }
    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        if (playerRB2D.velocity.y < 0)//transition to falling state
        {
            fsm.ChangeState(((PlayerMovementFSM)fsm).playerFallingState);
        }
    }
    public override void OnUpdatePhysics()
    {
        base.OnUpdatePhysics();
    }
    public override void OnExit()
    {
        base.OnExit();
    }
}