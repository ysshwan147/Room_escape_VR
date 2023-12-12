using UnityEngine;

public class TogglePhoneScreen : MonoBehaviour
{
    public MeshRenderer screenRenderer = null;
    public Material lightOffMat;
    public Material lightOnMat;

    public bool isOn = false;

    private Material[] mats;
    // Start is called before the first frame update
    void Start()
    {
        mats = new Material[2];
        mats[0] = screenRenderer.materials[0];

        setScreenMat();
    }

    public void Activated()
    {
        ToggleScreen();
        Debug.Log(screenRenderer.materials[0]);
        Debug.Log(screenRenderer.materials[1]);
    }


    private void ToggleScreen()
    {
        isOn = !isOn;

        setScreenMat();
    }

    private void setScreenMat()
    {
        if (isOn) {
            mats[1] = lightOnMat;
            screenRenderer.materials = mats;
        }
        else {
            mats[1] = lightOffMat;
            screenRenderer.materials = mats;
        }
    }
}
