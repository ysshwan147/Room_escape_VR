using System.Collections;
using UnityEngine;

public class HiddenSpaceSlide : MonoBehaviour
{
    public float targetSlide = -1.899f;
    public float slideSpeed = 2.0f;
    public PlayEffectSound sound;

    public void openTrigger()
    {
        sound.Play();
        StartCoroutine(SlideDoor());
    }

    IEnumerator SlideDoor()
    {
        float initialXPosition = transform.position.x;
        float targetXPosition = initialXPosition + targetSlide; // 목표 X 위치

        while (transform.position.x > targetXPosition)
        {
            float moveAmount = slideSpeed * Time.deltaTime;
            transform.Translate(Vector3.left * moveAmount);
            yield return null;
        }

        // 정확한 위치로 설정하여 오차를 보정합니다.
        transform.position = new Vector3(targetXPosition, transform.position.y, transform.position.z);

        sound.Stop();
    }
}
