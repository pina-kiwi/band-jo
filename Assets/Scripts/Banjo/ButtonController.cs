using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    private SpriteRenderer ButtonSpriteRenderer;
    public Sprite defaultSprite;
    public Sprite pressedSprite;
    

    private Image image;
    public KeyCode keyToPressForButtonActivation = KeyCode.A;

   // public KeyCode keyInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
        
        if (defaultSprite != null)
            image.sprite = defaultSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToPressForButtonActivation))
        {
            if (pressedSprite != null && image.sprite != pressedSprite)
            {
                image.sprite = pressedSprite;
                print("Pressed button");
            }
        }
        else if (Input.GetKeyUp(keyToPressForButtonActivation))
        {
            if (defaultSprite != null && image.sprite != defaultSprite)
            {
                image.sprite = defaultSprite;
            }
        }
        
    }
    
    
    
}
