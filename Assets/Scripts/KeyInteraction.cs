using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    public string nextScene = "OfficeRoom";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("key"))
        {
            Debug.Log("�浹");
            LoadingSceneController.LoadScene(nextScene);
        }
    }
}
