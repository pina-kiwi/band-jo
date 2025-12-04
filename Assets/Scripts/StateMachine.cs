using UnityEngine;

public interface IState
{
    void Enter();
    void Exit();
    void Execute();
}
public class StateMachine : MonoBehaviour
{
    public IState currentState {get; private set;}


    public void Initialize(IState startState)
    {
        currentState = startState;
        currentState.Enter();
    }


    public void ChangeState(IState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }


    // Update is called once per frame
    public void Update()
    {
        currentState?.Execute();
    }
}
