using System.Collections;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public BanjoFretBoundaries BanjoFretBoundaries;
    
    public GameObject redNotePrefab;
    public GameObject blueNotePrefab;
    public GameObject greenNotePrefab;
    public GameObject pinkNotePrefab;
    public GameObject purpleNotePrefab;

    
    
    
    public float spawnInterval = 0.5f;

    void Start()
    {
        StartCoroutine(CountdownUntilNoteSpawn());
        
    }
    
    

    public void SpawnRedNote()
    {
        Instantiate(redNotePrefab, new Vector3(2.5f, 0.9f, 0f), Quaternion.identity);
        
    }
    
    public void SpawnBlueNote()
    {
        Instantiate(blueNotePrefab, new Vector3(2.5f,0f,0f), Quaternion.identity);
        
    }
    
    public void SpawnGreenNote()
    {
        Instantiate(greenNotePrefab, new Vector3(2.5f,-0.45f,0f), Quaternion.identity);
        
    }
    
    public void SpawnPinkNote()
    {
        Instantiate(pinkNotePrefab,new Vector3(2.5f,-0.9f,0f), Quaternion.identity);
        
    }
    
    public void SpawnPurpleNote()
    {
        Instantiate(purpleNotePrefab, new Vector3(2.5f,0.45f,0f), Quaternion.identity);
        
    }

    IEnumerator CountdownUntilNoteSpawn()
    {
        //float maxNumberOfNotesToSpawn = 5f;
        float secondsToWait = Random.Range(GameParameters.minimumSecondsToWait, GameParameters.maximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        InvokeRepeating("SpawnRedNote", 0f, 7f);
        InvokeRepeating("SpawnBlueNote", 0f, 3f);
        InvokeRepeating("SpawnGreenNote", 0f,2f );
        InvokeRepeating("SpawnPinkNote", 0f, 5f);
        InvokeRepeating("SpawnPurpleNote", 0f, 10f); 
    }

   
}
