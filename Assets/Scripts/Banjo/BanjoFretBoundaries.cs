using UnityEngine;

public class BanjoFretBoundaries : MonoBehaviour
{

    public Rect fretBoundary;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteBoundary()
    {
        Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(pos.x, fretBoundary.xMin, fretBoundary.xMax);
                pos.y = Mathf.Clamp(pos.y, fretBoundary.yMin, fretBoundary.yMax);
                transform.position = pos;
    }
}
