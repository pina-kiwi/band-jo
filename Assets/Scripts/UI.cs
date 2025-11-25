using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;

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
}
