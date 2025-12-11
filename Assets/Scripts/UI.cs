using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    public CanvasGroup GameWinScreenCanvasGroup;
    public CanvasGroup GameLoseScreenCanvasGroup;
    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
        CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
    }

    public void ShowGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
        CanvasGroupDisplayer.Show(GameOverScreenCanvasGroup);
    }

    public void HideGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
    }

    public void ShowWinScreen()
    {
        CanvasGroupDisplayer.Show(GameWinScreenCanvasGroup);
    }

    public void HideWinScreen()
    {
        CanvasGroupDisplayer.Hide(GameWinScreenCanvasGroup);
    }

    public void ShowLoseScreen()
    {
        CanvasGroupDisplayer.Show(GameLoseScreenCanvasGroup);
    }

    public void HideLoseScreen()
    {
        CanvasGroupDisplayer.Hide(GameLoseScreenCanvasGroup);
    }
}
