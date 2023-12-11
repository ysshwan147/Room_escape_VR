using UnityEngine;

public class TogglePhoneScreen : MonoBehaviour
{
    public MeshRenderer screenRenderer = null;
    public Material lightOffMat;
    public Material lightOnMat;

    private bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        setScreenMat();
    }

    public void Activated()
    {
        ToggleScreen();
    }


    private void ToggleScreen()
    {
        isOn = !isOn;

        setScreenMat();
    }

    private void setScreenMat()
    {
        if (isOn) {
            screenRenderer.materials[1] = lightOnMat;
        }
        else {
            screenRenderer.materials[1] = lightOffMat;
        }
    }
}
