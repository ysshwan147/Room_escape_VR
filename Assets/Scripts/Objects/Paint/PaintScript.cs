using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintScript : MonoBehaviour
{
    public GameObject objectToActivate; // 활성화할 오브젝트

    private void Start()
    {
        if (objectToActivate != null) { objectToActivate.SetActive(false); }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("keyboard"))
        {
            StartCoroutine(DeactivateAfterSound(collision.gameObject));
        }
    }

    IEnumerator DeactivateAfterSound(GameObject collidedObject)
    {
        PlayEffectSound playEffectSound = GetComponent<PlayEffectSound>();
        if (playEffectSound != null)
        {
            playEffectSound.Play();
            // 재생 시간 동안 대기 (오디오 클립의 길이에 따라 조절하세요)
            yield return new WaitForSeconds(1); // 예시로 1초 대기
        }

        gameObject.SetActive(false); // 나 자신을 비활성화
        collidedObject.SetActive(false); // 충돌한 오브젝트를 비활성화

        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }
}
