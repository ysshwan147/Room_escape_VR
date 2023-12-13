using System.Collections;
using UnityEngine;

public class HiddenSpaceSlide : MonoBehaviour
{
    public float targetSlide = -1.899f;
    public float slideSpeed = 2.0f;

    public void openTrigger()
    {
        StartCoroutine(SlideDoor());
    }

    IEnumerator SlideDoor()
    {
        float initialXPosition = transform.position.x;
        float targetXPosition = initialXPosition + targetSlide; // ��ǥ X ��ġ

        while (transform.position.x > targetXPosition)
        {
            float moveAmount = slideSpeed * Time.deltaTime;
            transform.Translate(Vector3.left * moveAmount);
            yield return null;
        }

        // ��Ȯ�� ��ġ�� �����Ͽ� ������ �����մϴ�.
        transform.position = new Vector3(targetXPosition, transform.position.y, transform.position.z);
    }
}
