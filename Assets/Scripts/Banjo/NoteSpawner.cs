using System.Collections;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject redNotePrefab;
    public GameObject blueNotePrefab;
    public GameObject greenNotePrefab;
    public GameObject pinkNotePrefab;
    public GameObject purpleNotePrefab;
    public bool isOkayToCreate = false;
    
    public float spawnInterval = 1f;

    void Start()
    {
        StartCoroutine(CountdownUntilNoteSpawn());
        InvokeRepeating("SpawnRedNote", 0f, spawnInterval+0.5f);
        InvokeRepeating("SpawnBlueNote", 0f, spawnInterval+0.25f);
        InvokeRepeating("SpawnGreenNote", 0f, spawnInterval);
        InvokeRepeating("SpawnPinkNote", 0f, spawnInterval+0.55f);
        InvokeRepeating("SpawnPurpleNote", 0f, spawnInterval+0.75f);
    }
    
    

    public void SpawnRedNote()
    {
        Instantiate(redNotePrefab, new Vector3(2.5f,0.9f,0f), Quaternion.identity);
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
        float secondsToWait = Random.Range(GameParameters.minimumSecondsToWait, GameParameters.maximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
    }

    public void SpawnPlacement()
    {
        transform.position = new Vector3(3f, 2f, 0f);
    }
}
