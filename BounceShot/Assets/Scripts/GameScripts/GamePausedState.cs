using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePausedState : BaseState
{
    
    public GamePausedState(GameStateMachine gsm) : base("GamePausedState", gsm)
    {

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        //bring up the pause UI
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        //Update logic here
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Resumed game");
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        //Hide the pause UI
    }

}
