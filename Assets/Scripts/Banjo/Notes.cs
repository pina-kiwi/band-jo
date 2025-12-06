using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public NoteSpawner NoteSpawner;
    public GameObject blueNotePrefab;
    public float noteSpeed = 5f;

    void Start()
    {
        StartCoroutine(NoteDespawner());
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * noteSpeed);
    }

    IEnumerator NoteDespawner()
    {
        yield return new WaitForSeconds(GameParameters.NoteDespawnSpeed);
        Destroy(GameObject.FindGameObjectWithTag("Note"));
    }
}
