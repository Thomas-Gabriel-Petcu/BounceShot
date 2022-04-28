using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFSM : FiniteStateMachine
{
    public GameObject player;
    public float jumpForce;
    public PlayerIdleState playerIdleState;
    public PlayerJumpState playerJumpState;
    public PlayerFallingState playerFallingState;

    private void Awake()
    {
        playerIdleState = new PlayerIdleState(this);
        playerJumpState = new PlayerJumpState(this, jumpForce, player);
        playerFallingState = new PlayerFallingState(this, player);
    }

    public override void Start()
    {
        base.Start();
    }

    protected override BaseState GetInitialState()
    {
        return playerIdleState;
    }
}
