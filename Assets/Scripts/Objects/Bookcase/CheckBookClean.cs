using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBookClean : MonoBehaviour
{
    public HiddenSpaceSlide hiddenSpace;

    private int cleanCount = 0;

    private void Update()
    {
        if (cleanCount >= 12)
        {
            hiddenSpace.openTrigger();

            enabled = false;
        }
    }

    public void SelectEntered()
    {
        cleanCount++;
    }

    public void SelectExited()
    {
        cleanCount--;
    }
}
