using UnityEngine;

public class PlayerIdleState : BaseState
{
    GameObject _player;
    public PlayerIdleState(PlayerMovementFSM pmfsm) : base("PlayerIdleState", pmfsm) { }

    public override void OnEnterState()
    {
        base.OnEnterState();
        if (_player == null) _player = GameObject.FindGameObjectWithTag("Player");
        if (_player == null) return;
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        if (_player == null) return;
        if (Input.GetKeyDown(KeyCode.Space))
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
