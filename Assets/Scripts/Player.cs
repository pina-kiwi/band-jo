using UnityEngine;

public class Player : MonoBehaviour
{
    
    public SpriteRenderer HeartSpriteRenderer;
    
    public StateMachine StateMachine {get; private set;}
    public IState MainState {get; private set;}
    public IState CombatState {get; private set;}
    
    public Player()
    {
        StateMachine = gameObject.AddComponent<StateMachine>();
        MainState = new MainState(this);
        CombatState = new CombatState(this);
    }
    
    public void Initialize()
    {
        StateMachine.Initialize(MainState);
    }
    
    public void UpdatePlayer()
    {
        StateMachine.Update();
    }
}
