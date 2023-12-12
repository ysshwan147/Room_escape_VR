using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            // Specific event logic here
            Debug.Log("Key has touched the object!");
        }
    }
}
