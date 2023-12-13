using UnityEngine;

public class ToggleSwitch : MonoBehaviour
{
    public bool isOn = false;
    public Subtitle subtitle;

    private void Start()
    {
        isOn = false;
    }

    public void SelectEntered()
    {
        ToggleLightOnOff();
        ActivateSubtitle();
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

    private void ActivateSubtitle()
    {
        if (isOn)
        {
            if (subtitle != null)
            {
                subtitle.gameObject.SetActive(true);
            }
        }
    }
}
