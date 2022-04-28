using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamePausedState : BaseState
{
    private GameObject _menu;
    private Transform _child;
    public GamePausedState(GameStateMachine gsm) : base("GamePausedState", gsm)
    {

    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        _menu = GameObject.Find("Menu");
        _child = _menu.transform.GetChild(0);
        _child.gameObject.SetActive(true);
        _menu.transform.GetChild(2).gameObject.SetActive(true);
        Time.timeScale = 0;
        //bring up the pause UI
    }

    public override void OnUpdateLogic()
    {
        base.OnUpdateLogic();
        //Update logic here
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            fsm.ChangeState(((GameStateMachine)fsm).gameRunningState);
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        _child.gameObject.SetActive(false);
        _menu.transform.GetChild(2).gameObject.SetActive(false);
        //Hide the pause UI
    }

    public void Quit()
    {
        Application.Quit();
    }

}
