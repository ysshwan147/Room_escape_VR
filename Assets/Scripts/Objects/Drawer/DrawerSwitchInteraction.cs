using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSwitchInteraction : MonoBehaviour
{
    public Transform hinge; // ��ø�� ��ġ�� ��Ÿ���� �� GameObject
    public float rotationAngle = 90f; // ȸ�� ����
    public float rotationSpeed = 5f; // ȸ�� �ӵ�

    private void Start()
    {
        //OnVRInteract();
    }

    // VR ���ͷ��� �޼ҵ�
    public void OnVRInteract()
    {
        StartCoroutine(RotateDoor(rotationAngle, rotationSpeed));
    }

    private IEnumerator RotateDoor(float angle, float speed)
    {
        Quaternion startRotation = hinge.rotation;
        Quaternion endRotation = hinge.rotation * Quaternion.Euler(0, angle, 0);
        float t = 0.0f;

        while (t < 1f)
        {
            t += Time.deltaTime * speed;
            hinge.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }
    }
}
