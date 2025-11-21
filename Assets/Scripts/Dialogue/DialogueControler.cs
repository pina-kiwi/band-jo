using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class DialogueControler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NPCNameText;
    [SerializeField] private TextMeshProUGUI NPCDialogueText;
    [SerializeField] private float typeSpeed = 10f;
    
    private Queue<string> paragraph = new Queue<string>();
    private bool conversationEnded = false;
    
    private string p;
    
    private Coroutine typeDialogueCoroutine;
    private bool isTyping;

    private const string HTML_ALPHA = "<color=#00000000>";
    private const float MAX_TYPE_TIME = .1f;
    
    public void DisplayNextParagraph(DialogueText dialogueText)
    {
        if (paragraph.Count == 0)
        {
            if (!conversationEnded)
            {
                StartConversation(dialogueText);
            }
            else if (conversationEnded && !isTyping)
            {
                EndConversation();
                return;
            }
        }

        if (!isTyping)
        {
            p = paragraph.Dequeue();
            typeDialogueCoroutine = StartCoroutine(TypeDialogueText(p));
        }
        else
        {
            FinishParagraphEarly();
        }

        
        if (paragraph.Count == 0)
        {
            conversationEnded = true;
        }
    }
/*
    private IEnumerator TypeDialogueText(string p)
    {
        isTyping = true;
        NPCDialogueText.text = "";

        for (int i = 0; i < p.Length; i++)
        {
            NPCDialogueText.text = p.Substring(0, i + 1);
            yield return new WaitForSeconds(waitUntilNextLetter);
        }

        isTyping = false;
    }
*/
    private IEnumerator TypeDialogueText(string p)
    {
        isTyping = true;
        
        NPCDialogueText.text = "";
        
        string originalText = p;
        string displayedText = "";
        int alphaIndex = 0;

        foreach (char c in p.ToCharArray())
        {
            alphaIndex++;
            NPCDialogueText.text = originalText;
            
            displayedText = NPCDialogueText.text.Insert(alphaIndex, HTML_ALPHA);
            
            NPCDialogueText.text = displayedText;
            
            yield return new WaitForSeconds(MAX_TYPE_TIME/ typeSpeed);
            
        }
        
        isTyping = false;
    }

    private void StartConversation(DialogueText dialogueText)
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }

        NPCNameText.text = dialogueText.speakerName;

        for (int i = 0; i < dialogueText.paragraphs.Length; i++)
        {
            paragraph.Enqueue(dialogueText.paragraphs[i]);
        }
    }

    private void EndConversation()
    {
        paragraph.Clear();
        
        conversationEnded = false;
        
        if(gameObject.activeSelf)
            gameObject.SetActive(false);
    }

    private void FinishParagraphEarly()
    {
        StopCoroutine(typeDialogueCoroutine);
        NPCDialogueText.text = p;
        isTyping = false;
    }
}
