using System;
using UnityEngine;

public class BanjoLane : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RedNote" && Input.GetKeyDown(KeyCode.A))
        {
            Destroy(other.gameObject);

        }
    }
}
