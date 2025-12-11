using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    public float noteSpeed;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * noteSpeed);
    }

    public void NoteSpeeding()
    {
        transform.Translate(Vector2.left * Time.deltaTime * noteSpeed);
    }
}
