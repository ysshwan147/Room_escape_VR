using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSwitchInteraction : MonoBehaviour
{
    public Transform hinge; // 경첩의 위치를 나타내는 빈 GameObject
    public float rotationAngle = 90f; // 회전 각도
    public float rotationSpeed = 5f; // 회전 속도

    private void Start()
    {
        //OnVRInteract();
    }

    // VR 인터랙션 메소드
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
