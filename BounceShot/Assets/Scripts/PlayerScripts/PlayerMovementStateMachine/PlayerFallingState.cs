using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallingState : BaseState
{
    private GameObject _player;
    private Rigidbody2D _playerRB2D;
    public PlayerFallingState(PlayerMovementFSM pmfsm, GameObject player) : base("PlayerFallingState", pmfsm)
    {
        _player = player;
        _playerRB2D = player.GetComponent<Rigidbody2D>();
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
    }

    public override void OnExit()
    {
        base.OnExit();
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        if (_playerRB2D.velocity.y == 0)//hit the ground
        {
            fsm.ChangeState(((PlayerMovementFSM)fsm).playerIdleState);
        }
    }

    public override void OnUpdatePhysics()
    {
        base.OnUpdatePhysics();
    }
}
