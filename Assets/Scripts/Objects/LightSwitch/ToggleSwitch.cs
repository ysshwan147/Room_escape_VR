using UnityEngine;

public class ToggleSwitch : MonoBehaviour
{
    public bool isOn = false;

    private void Start()
    {
        isOn = false;
    }

    public void SelectEntered()
    {
        ToggleLightOnOff();
    }


    private void ToggleLightOnOff()
    {
        isOn = !isOn;

        Vector3 eulerAngle = transform.eulerAngles;

        if (isOn)
        {
            eulerAngle.z += 180.0f;
        }
        else
        {
            eulerAngle.z -= 180.0f;
        }

        transform.eulerAngles = eulerAngle;
    }
}
