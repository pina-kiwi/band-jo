using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceroller : MonoBehaviour
{
    public Game Game;
    public UI UI;
    public List<int> Dice = new List<int> {1,2,3,4,5,6};
    public Text DiceRoll;
    public GameObject Button;
    public GameObject PlayAgainButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    //click on button
    public void DiceRoller()
    {
            Button.GetComponent<Button>().interactable = false;
            //dice roll 1-6 (0-5)
            int dice = Random.Range(0, Dice.Count);
            DiceRoll.text = Dice[dice].ToString();
            if (Dice[dice] <= 3)//if DR = 1-3, win
            {
                StartCoroutine(ShowLoseScreen());
                
                
                
            }
            else//else = lose
            {
                StartCoroutine(ShowWinScreen());
               
            }
            
        
            
            
    }

    IEnumerator ShowLoseScreen()
    {
        float waitSeconds = 2f;
        yield return new WaitForSeconds(waitSeconds);
        UI.ShowLoseScreen();
        Button.SetActive(false);
    }

    IEnumerator ShowWinScreen()
    {
        float waitSeconds = 2f;
        yield return new WaitForSeconds(waitSeconds);
         UI.ShowWinScreen();
         Button.SetActive(false);
    }
    
    
        
            
}
