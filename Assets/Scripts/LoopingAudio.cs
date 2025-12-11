using UnityEngine;

public class LoopingAudio : MonoBehaviour
{
    public AudioClip audioClip;       
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = audioClip;
        audioSource.loop = true;      
        audioSource.playOnAwake = true;
    }

    void Start()
    {
        audioSource.Play();
    }
}