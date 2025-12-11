using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Notes : MonoBehaviour
{
    private NoteSpawner NoteSpawner;
    private NoteMovement NoteMovement;
    private BanjoFretBoundaries BanjoFretBoundaries;
    public bool isAbleToBePressed;
    public float noteSpeed = 5f;
    public KeyCode activateKey;
    
   
    void Start()
    {
        
        
    }
    void Update()
    {
        
            
        
        
        
        /*
        if (isAbleToBePressed && Input.GetKeyDown(activateKey))
        {
            print("note hit");
            Destroy(gameObject);
        }*/
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Button")
        {
            isAbleToBePressed = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            isAbleToBePressed = false;
        }
    }

  

    
}
