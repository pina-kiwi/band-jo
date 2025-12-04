using System;
using UnityEngine;

public class MainState : IState
{
    private Player player;
    public SceneChanger sceneChanger;
    // public Move2D move;
    // public FirstBoss dialogue;
  
    public MainState(Player player) =>  this.player = player;


    public void Enter()
    {
        sceneChanger.LoadMainScene();
        // player.Reset();
        Console.WriteLine("Entering Walking State");
    }


    public void Execute()
    {
        /*
        // handle movement logic
        move.Update();
      
        // handle dialogue/npc interact input
        dialogue.Interact();
        
        This may not be necessary with the scene change, because as long as 
        the main scene is active all this code will be too.
        */
      
        // if (the player walks into the combat building trigger)
            // player.StateMachine.ChangeState(player.CombatState);
    }


    public void Exit()
    {
        Console.WriteLine("Exiting Walking State");
    }
}

