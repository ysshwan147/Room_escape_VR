using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenSpaceAnchor : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    public void openTrigger()
    {
        StartCoroutine(RotateDoor());
    }

    IEnumerator RotateDoor()
    {
        float targetRotation = 270.0f; // ��ǥ ȸ�� ����

        do
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotationAmount);
            yield return null;
        } while (transform.rotation.eulerAngles.y > targetRotation);

        // ��Ȯ�� ������ �����Ͽ� ������ �����մϴ�.
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation, transform.rotation.eulerAngles.z);
    }
}
