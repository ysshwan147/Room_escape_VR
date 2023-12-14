using UnityEngine;

public class Computer : MonoBehaviour
{
    public string correctPassword;

    public MeshRenderer mainScreen;
    public MeshRenderer subScreen;

    public GameObject numpad;

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
        numpad.SetActive(false);

        mainScreen.material = offMat;
        subScreen.material = offMat;

        effectSound = GetComponent<PlayEffectSound>();
    }

    public void turnOnComputer()
    {
        numpad.SetActive(true);

        mainScreen.material = loginMat;

        playSound(turnOnSound);
    }

    public void turnOffComputer()
    {
        numpad.SetActive(false);

        mainScreen.material = offMat;
        subScreen.material = offMat;

        playSound(turnOffSound);
    }

    public void loginComputer()
    {
        numpad.SetActive(false);

        mainScreen.material = sylla1Mat;
        subScreen.material = sylla2Mat;

        playSound(loginSound);
    }


    public void loginFailComputer()
    {
        playSound(loginFailSound);
    }


    public void login(string password)
    {
        if (string.IsNullOrEmpty(password)) { return; }

        if (password.Equals(correctPassword))
        {
            loginComputer();
        }
        else
        {
            loginFailComputer();
        }
    }


    private void playSound(AudioClip sound)
    {
        effectSound.sound = sound;
        effectSound.Stop();
        effectSound.Play();
    }
}
