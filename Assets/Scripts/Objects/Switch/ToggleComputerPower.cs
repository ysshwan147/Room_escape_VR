using UnityEngine;

public class ToggleComputerPower : MonoBehaviour
{
    public Computer computer;
    public bool isOn = false;

    public void SelectEntered()
    {
        toggleComputer();
    }

    private void toggleComputer()
    {
        isOn = !isOn;

        if (isOn)
        {
            computer.turnOnComputer();
        }
        else
        {
            computer.turnOffComputer();
        }
    }
}
