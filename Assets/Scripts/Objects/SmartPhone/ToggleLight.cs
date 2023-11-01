using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public bool isOn = false;
    private Light currentLight = null;

    private void Awake()
    {
        currentLight = GetComponent<Light>();
    }

    private void Start()
    {
        currentLight.enabled = isOn;
    }

    public void Activated()
    {
        ToggleLightOnOff();
    }


    private void ToggleLightOnOff()
    {
        isOn = !isOn;
        currentLight.enabled = isOn;
    }
}
