using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Player Player;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDefenseMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Player.Move(new Vector2(0,1));
        }

        if (Input.GetKey(KeyCode.S))
        {
            Player.Move(new Vector2(0,-1));
        }

        if (Input.GetKey(KeyCode.A))
        {
            Player.Move(new Vector2(-1, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.Move(new Vector2(1, 0));
        }
    }
}
