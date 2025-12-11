using UnityEngine;

public class Game : MonoBehaviour
{
    public SceneChanger sceneChanger;
    public UI UI;
    public bool isPlaying = false;

    public void OnStartButtonClick()
    {
        UI.HideStartScreen();
        InitializeGame();
    }

    public void OnPlayAgainClick()
    {
        UI.HideWinScreen();
        UI.HideLoseScreen();
        InitializeGame();
    }

    public void InitializeGame()
    {
        isPlaying = true;
        sceneChanger.LoadMainScene();
    }
}
