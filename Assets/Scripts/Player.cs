using UnityEngine;

public class Player : MonoBehaviour
{
    
    
    public SpriteRenderer HeartSpriteRenderer;
    
    
    public void Move(Vector2 direction)
    {
        
        float xAmount = direction.x * GameParameters.HeartMoveSpeed * Time.deltaTime;
        float yAmount = direction.y * GameParameters.HeartMoveSpeed * Time.deltaTime;
      
      
        HeartSpriteRenderer.transform.Translate(xAmount, yAmount, 0f);
        HeartSpriteRenderer.transform.position =
            SpriteTools.ConstrainToScreen(HeartSpriteRenderer);
    }
}
