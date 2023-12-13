using System.Collections;
using UnityEngine;

public class HiddenSpaceAnchor : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public PlayEffectSound sound;

    public void openTrigger()
    {
        sound.Play();
        Debug.Log("Play");
        StartCoroutine(RotateDoor());
    }

    IEnumerator RotateDoor()
    {
        float targetRotation = 270.0f; // 목표 회전 각도

        do
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotationAmount);
            yield return null;
        } while (transform.rotation.eulerAngles.y > targetRotation);

        // 정확한 각도로 설정하여 오차를 보정합니다.
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation, transform.rotation.eulerAngles.z);

        sound.Stop();
        Debug.Log("Stop");
    }
}
