using UnityEngine;

public class FirstBoss : NPC, ITalkable
{
    [SerializeField] private DialogueText dialogueText;
    [SerializeField] private DialogueControler dialogueControler;
    
    public override void Interact()
    {
        Talk(dialogueText);
    }

    public void Talk(DialogueText dialogueText)
    {
        dialogueControler.DisplayNextParagraph(dialogueText);
    }
}
