using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BanjoFretBoundaries : MonoBehaviour
{

    public float fretBoundaryMinXPosition= -3f;
    public float fretBoundaryMaxXPosition = 3f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate new position
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * Time.deltaTime, 0, 0);

        // Clamp the new X position to be within the defined limits
        newPosition.x = Mathf.Clamp(newPosition.x, fretBoundaryMinXPosition, fretBoundaryMaxXPosition);

        // Apply the final, clamped position
        transform.position = newPosition;

        if (transform.position.x <= fretBoundaryMinXPosition || transform.position.x >= fretBoundaryMaxXPosition)
        {
            Destroy(gameObject);
        }
        
    }

    
}
