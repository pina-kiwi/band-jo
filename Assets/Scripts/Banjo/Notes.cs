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
    private BanjoFretBoundaries BanjoFretBoundaries;
    public bool isAbleToBePressed = false;
    public float noteSpeed = 5f;
    public KeyCode activateKey;

    void Start()
    {
        
        
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * noteSpeed);
        
    }

  

    
}
