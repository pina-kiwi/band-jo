using UnityEngine;

public class ButtonHits : MonoBehaviour
{
    public bool isAbleToBePressed = false;

    //public float noteSpeed = 5f;
    public KeyCode activateKey;

    public Vector2 rayDirection = Vector2.up;
    public float rayDistance = 1f;
    public LayerMask noteLayer;

    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, rayDistance, noteLayer);
        if (hit.collider != null && hit.collider.CompareTag("Note"))
        {
            if (Input.GetKeyDown(activateKey))
            {
                Destroy(hit.collider.gameObject);
                // Add score logic here
            }


        }
    }
}

/*

if (Input.GetKeyDown(activateKey))
{
    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left);
    if (hit.collider != null && hit.collider.CompareTag("Note")) {
        Destroy(hit.collider.gameObject);
        // Add score logic here
    }
}
}

/*
void Update()
{
if (isAbleToBePressed && Input.GetKeyDown(activateKey))
{
    print("note hit");
    Destroy(gameObject);
}
}

public void OnCollisionEnter2D(Collision2D other)
{
if (other.gameObject.layer == noteLayer)
{
    if (other.gameObject.tag == "Button")
    {
        isAbleToBePressed = true;
    }
}
}

public void OnCollisionExit2D(Collision2D other)
{
if (other.gameObject.layer == noteLayer)
{
    if (other.gameObject.tag == "Button")
    {
        isAbleToBePressed = false;
    }
}
}


}*/
