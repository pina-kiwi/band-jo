using UnityEngine;

public class Game : MonoBehaviour
{
    public UI UI;
    public bool isPlaying = false;
    public Player player;

    public void OnStartButtonClick()
    {
        UI.HideStartScreen();
        InitializeGame();
        player.Initialize();
    }

    public void InitializeGame()
    {
        isPlaying = true;
    }
}
