using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunningState : BaseState
{
    public GameRunningState(GameStateMachine gsm) : base("GameRunningState", gsm)
    {

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        //resume the game
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        //Update logic here
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Paused game");
            fsm.ChangeState(((GameStateMachine)fsm).gamePausedState);
        }
    }
    
    public override void OnExit()
    {
        base.OnExit();
        //pause the game
    }
}
