using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmSound : MonoBehaviour
{
    public AudioClip sound;
    public float volume = 1.0f;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Play();
    }

    public void Play()
    {
        audioSource.PlayOneShot(sound, volume);
    }

    public void Stop()
    {
        audioSource.Stop();
    }
}
