using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine : FiniteStateMachine
{
    [HideInInspector]
    public GamePausedState gamePausedState;
    [HideInInspector]
    public GameRunningState gameRunningState;

    private void Awake()
    {
        gamePausedState = new GamePausedState(this);
        gameRunningState = new GameRunningState(this);
    }

    protected override BaseState GetInitialState()
    {
        return gameRunningState;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
