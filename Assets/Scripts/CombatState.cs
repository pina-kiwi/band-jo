using System;
using UnityEngine;

public class CombatState : MonoBehaviour, IState
{
    public Player player;
    public SceneChanger sceneChanger;
  
    public CombatState(Player player) =>  this.player = player;


    public void Enter()
    {
        sceneChanger.LoadFightScene();
        Console.WriteLine("Entering Combat State");
    }


    public void Execute()
    {
        // if (player health drops to zero)
            // game.GameOver();
        // if (enemy health drops to zero)
            // game.WinGame();
        // possibly include combat logic, may not be necessary because of scene change
    }


    public void Exit()
    {
        
        Console.WriteLine("Exiting Combat State");
    }
}
