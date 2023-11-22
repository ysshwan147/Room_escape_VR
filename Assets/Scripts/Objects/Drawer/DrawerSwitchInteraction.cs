using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSwitchInteraction : MonoBehaviour
{
    public Transform hinge; // ��ø�� ��ġ�� ��Ÿ���� �� GameObject
    public float rotationAngle = -90f; // ȸ�� ����
    public float rotationSpeed = 0.5f; // ȸ�� �ӵ�
    private int isOpened = 0;
    private bool isRotating = false; // ȸ�� ������ ���θ� ��Ÿ���� �÷���

    private void Start()
    {
        //OnVRInteract();
    }

    // VR ���ͷ��� �޼ҵ�
    public void OnVRInteract()
    {
        if (isRotating)
        {
            // �̹� ȸ�� ���̸� �ƹ� �۾��� �������� ����
            return;
        }

        // isOpened ���¿� ���� ȸ�� ������ ����
        float angle = isOpened == 0 ? rotationAngle : -rotationAngle;

        StartCoroutine(RotateDoor(angle, rotationSpeed));

        // isOpened ���� ������Ʈ
        isOpened = isOpened == 0 ? 1 : 0;
    }

    private IEnumerator RotateDoor(float angle, float speed)
    {
        isRotating = true; // ȸ�� ����
        Quaternion startRotation = hinge.rotation;
        Quaternion endRotation = hinge.rotation * Quaternion.Euler(0, angle, 0);
        float t = 0.0f;

        while (t < 1f)
        {
            t += Time.deltaTime * speed;
            hinge.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }

        isRotating = false; // ȸ�� �Ϸ�
    }
}
