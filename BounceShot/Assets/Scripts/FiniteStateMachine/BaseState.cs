using UnityEngine;

public abstract class BaseState
{
    public string name;
    protected FiniteStateMachine fsm;
    public BaseState(string name, FiniteStateMachine fsm)
    {
        this.name = name;
        this.fsm = fsm;
    }

    public virtual void OnEnterState() { }

    public virtual void OnUpdateLogic() { }

    public virtual void OnUpdatePhysics() { }

    public virtual void OnExit() { }
}
