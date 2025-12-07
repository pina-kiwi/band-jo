using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadFightScene()
    {
        // store badger position
        // PersistentData.BadgerCellLocation = where is sbadget
            
        SceneManager.LoadScene(1);
        Console.WriteLine("Loading fight scene");
    }

    public void LoadMainScene()
    {
        // store health
        // store who won
        
        SceneManager.LoadScene(0);
    }
}
