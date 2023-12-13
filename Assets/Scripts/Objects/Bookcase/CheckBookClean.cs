using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBookClean : MonoBehaviour
{
    private int cleanCount = 0;

    private void Update()
    {
        if (cleanCount >= 1)
        {
            // do something
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
