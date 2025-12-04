using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public SpriteRenderer HeartSpriteRenderer;

    public StateMachine StateMachine;
    public MainState MainState;
    public CombatState CombatState;

    public void Initialize()
    {
        StateMachine.Initialize(MainState);
        StateMachine.Update();
    }
}
