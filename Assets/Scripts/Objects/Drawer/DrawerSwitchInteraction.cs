using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSwitchInteraction : MonoBehaviour
{
    public Transform hinge; // 경첩의 위치를 나타내는 빈 GameObject
    public float rotationAngle = -90f; // 회전 각도
    public float rotationSpeed = 0.5f; // 회전 속도
    private int isOpened = 0;
    private bool isRotating = false; // 회전 중인지 여부를 나타내는 플래그

    private void Start()
    {
        //OnVRInteract();
    }

    // VR 인터랙션 메소드
    public void OnVRInteract()
    {
        if (isRotating)
        {
            // 이미 회전 중이면 아무 작업도 수행하지 않음
            return;
        }

        // isOpened 상태에 따라 회전 방향을 결정
        float angle = isOpened == 0 ? rotationAngle : -rotationAngle;

        StartCoroutine(RotateDoor(angle, rotationSpeed));

        // isOpened 상태 업데이트
        isOpened = isOpened == 0 ? 1 : 0;
    }

    private IEnumerator RotateDoor(float angle, float speed)
    {
        isRotating = true; // 회전 시작
        Quaternion startRotation = hinge.rotation;
        Quaternion endRotation = hinge.rotation * Quaternion.Euler(0, angle, 0);
        float t = 0.0f;

        while (t < 1f)
        {
            t += Time.deltaTime * speed;
            hinge.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }

        isRotating = false; // 회전 완료
    }
}
