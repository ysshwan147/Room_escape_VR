using UnityEngine;

public class Computer : MonoBehaviour
{
    public MeshRenderer mainScreen;
    public MeshRenderer subScreen;

    public Material offMat;
    public Material loginMat;
    public Material sylla1Mat;
    public Material sylla2Mat;

    public AudioClip turnOnSound;
    public AudioClip turnOffSound;
    public AudioClip loginSound;
    public AudioClip loginFailSound;

    private PlayEffectSound effectSound;

    // Start is called before the first frame update
    void Start()
    {
        mainScreen.material = offMat;
        subScreen.material = offMat;

        effectSound = GetComponent<PlayEffectSound>();
    }

    public void turnOnComputer()
    {
        mainScreen.material = loginMat;

        playSound(turnOnSound);
    }

    public void turnOffComputer()
    {
        mainScreen.material = offMat;
        subScreen.material = offMat;

        playSound(turnOffSound);
    }

    public void loginComputer()
    {
        mainScreen.material = sylla1Mat;
        subScreen.material = sylla2Mat;

        playSound(loginSound);
    }


    public void loginFailComputer()
    {
        playSound(loginFailSound);
    }


    private void playSound(AudioClip sound)
    {
        effectSound.sound = sound;
        effectSound.Stop();
        effectSound.Play();
    }
}
