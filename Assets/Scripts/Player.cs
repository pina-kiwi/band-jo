using UnityEngine;

public class Player : MonoBehaviour
{
    public SceneChanger sceneChanger;
    public SpriteRenderer HeartSpriteRenderer;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("FightTrigger"))
        {
            sceneChanger.LoadFightScene();
        }
    }
}
