using UnityEngine;

public class EnemyPellet : MonoBehaviour
{
    public float pelletSpeed = 2.5f;
    public float pelletDuration = 5f;
    public Transform enemyTarget;

   


    void Start()
    {
        //SpawnEnemyPellet();
        //Destroy(gameObject, pelletDuration);
    }

    void Update()
    {
        if (enemyTarget == null)
        {
            Destroy(gameObject);
            return;
        }
        
        Vector3 direction = (enemyTarget.position - transform.position).normalized;
        transform.position += direction * pelletSpeed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (enemyTarget != null && other.transform == enemyTarget)
        {
            Destroy(gameObject);
        }
    }
    
    
}

