using UnityEngine;
using UnityEngine.PlayerLoop;

public class PelletSpawner : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform pelletSpawnPoint;
    public Transform heartTarget;

    public float pelletCoolDown = 1.5f;
    void Update()
    {
        
            SpawnPellet();
            pelletCoolDown = 1.5f;
            
    }

    private void SpawnPellet()
    {
        if (pelletPrefab != null && heartTarget != null)
        {
            GameObject newPellet = Instantiate(pelletPrefab, new Vector3(1147f, 500f, 0f), Quaternion.identity);
            newPellet.transform.parent = heartTarget;
        }
        
            //Instantiate(pelletPrefab, new Vector3(1147f, 500f, 0f), Quaternion.identity);
        
    }
}
