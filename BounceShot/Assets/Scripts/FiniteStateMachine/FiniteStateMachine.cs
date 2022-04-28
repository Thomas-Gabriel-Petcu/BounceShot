using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FiniteStateMachine : MonoBehaviour
{
    BaseState _currentState;


    public virtual void Start()
    {
        _currentState = GetInitialState();
        if (_currentState != null)
        {
            _currentState.OnEnterState();
        }
    }
    private void Update()
    {
        if (_currentState !=null)
        {
            _currentState.OnUpdateLogic();
        }
    }

    private void FixedUpdate()
    {
        if (_currentState != null)
        {
            _currentState.OnUpdatePhysics();
        }
    }

    public void ChangeState(BaseState state)
    {
        _currentState.OnExit();
        _currentState = state;
        _currentState.OnEnterState();
    }

    protected virtual BaseState GetInitialState()
    {
        return null;
    }
}
