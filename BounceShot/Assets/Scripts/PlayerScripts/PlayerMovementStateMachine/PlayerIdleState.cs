using UnityEngine;

public class PlayerIdleState : BaseState
{
    public PlayerIdleState(PlayerMovementFSM pmfsm) : base("PlayerIdleState", pmfsm) { }

    public override void OnEnterState()
    {
        base.OnEnterState();
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        if (Input.GetKey(KeyCode.Space))
        {
            fsm.ChangeState(((PlayerMovementFSM)fsm).playerJumpState);
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
