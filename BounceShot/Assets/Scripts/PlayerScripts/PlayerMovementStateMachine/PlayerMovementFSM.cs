using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFSM : FiniteStateMachine
{
    [HideInInspector]
    public PlayerIdleState playerIdleState;
    [HideInInspector]
    public PlayerJumpState playerJumpState;

    private void Awake()
    {
        playerIdleState = new PlayerIdleState(this);
        playerJumpState = new PlayerJumpState(this);
    }

    protected override BaseState GetInitialState()
    {
        return playerIdleState;
    }
}
