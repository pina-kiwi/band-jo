using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class NoteSpawner : MonoBehaviour
{
    public BanjoFretBoundaries BanjoFretBoundaries;
    
    public GameObject redNotePrefab;
    public GameObject blueNotePrefab;
    public GameObject greenNotePrefab;
    public GameObject pinkNotePrefab;
    public GameObject purpleNotePrefab;

    public float noteSpeed = 2f;
    
    
    
    public float spawnInterval = 0.5f;

    void Start()
    {
        StartCoroutine(CountdownUntilNoteSpawn());
        SpawnAllNotes();
        
    }

    public void SpawnAllNotes()
    {
        InvokeRepeating("SpawnRedNote", 0f, 7f);
        InvokeRepeating("SpawnBlueNote", 1f, 3f);
        InvokeRepeating("SpawnGreenNote", 0.5f,2f );
        InvokeRepeating("SpawnPinkNote", 1.5f, 5f);
        InvokeRepeating("SpawnPurpleNote", 2f, 10f); 
    }

    public void SpawnRedNote()
    {
        Instantiate(redNotePrefab, new Vector3(1207f, 639.2f, 0f), Quaternion.identity);
    }
    
    public void SpawnBlueNote()
    {
        Instantiate(blueNotePrefab, new Vector3(1207f,540.7f,0f), Quaternion.identity);
        
        
    }
    
    public void SpawnGreenNote()
    {
        Instantiate(greenNotePrefab, new Vector3(1207f,494.8f,0f), Quaternion.identity);
        
    }
    
    public void SpawnPinkNote()
    {
        Instantiate(pinkNotePrefab,new Vector3(1207f,443.2f,0f), Quaternion.identity);
        
    }
    
    public void SpawnPurpleNote()
    {
        Instantiate(purpleNotePrefab, new Vector3(1207f,588.7f,0f), Quaternion.identity);
       
    }

    IEnumerator CountdownUntilNoteSpawn()
    {
        //float maxNumberOfNotesToSpawn = 5f;
        float secondsToWait = Random.Range(GameParameters.minimumSecondsToWait, GameParameters.maximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
       
        
    }

   
}
