using UnityEngine;

public class PlayEffectSound : MonoBehaviour
{
    public AudioClip sound;
    public float volume = 1.0f;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
