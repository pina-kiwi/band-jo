using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadFightScene()
    {
        // SceneManager.LoadScene(1);
        Console.WriteLine("Loading fight scene");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
