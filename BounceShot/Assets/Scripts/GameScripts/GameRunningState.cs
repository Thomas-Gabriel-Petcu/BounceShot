using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunningState : BaseState
{
    DefenseObjective defenseObjective;
    private GameObject _menu;
    private Transform _child;

    public GameRunningState(GameStateMachine gsm) : base("GameRunningState", gsm)
    {

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        Time.timeScale = 1;
        defenseObjective = GameObject.Find("DefenseObjective").GetComponent<DefenseObjective>();
        _menu = GameObject.Find("Menu");
        _child = _menu.transform.GetChild(1);
        //resume the game
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        //Update logic here
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            fsm.ChangeState(((GameStateMachine)fsm).gamePausedState);
        }
        if (defenseObjective.Health <=0)
        {
            _child.gameObject.SetActive(true);
            ScoreManager.Instance.SaveScore();
            fsm.ChangeState(((GameStateMachine)fsm).gamePausedState);
        }
    }
    
    public override void OnExit()
    {
        base.OnExit();
        //pause the game
    }
}
