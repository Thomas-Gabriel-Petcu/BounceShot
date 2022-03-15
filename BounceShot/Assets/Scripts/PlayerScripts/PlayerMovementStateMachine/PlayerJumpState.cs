using UnityEngine;

public class PlayerJumpState : BaseState
{
    GameObject _player;
    public PlayerJumpState(PlayerMovementFSM pmfsm) : base("PlayerJumpState", pmfsm) { }

    public override void OnEnterState()
    {
        base.OnEnterState();
        if (_player == null) _player = GameObject.FindGameObjectWithTag("Player");
        if (_player == null) return;
        if (!_player.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb)) return;

        Debug.Log("Jumped");
    }
    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        if (_player == null) return;
        
        
        //fsm.ChangeState(((PlayerMovementFSM)fsm).playerIdleState);
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