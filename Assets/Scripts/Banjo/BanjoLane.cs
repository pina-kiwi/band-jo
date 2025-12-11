using System;
using UnityEngine;

public class BanjoLane : MonoBehaviour
{

    public bool isAbleToBePressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAbleToBePressed)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Destroy(gameObject);
            }
        }
        
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
