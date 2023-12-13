using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteraction : MonoBehaviour
{
    public string nextScene = "OfficeRoom";
    public GameObject bgmGameObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("key"))
        {
            StartCoroutine(ChangeScene());
        }
    }

    private IEnumerator ChangeScene()
    {
        PlayEffectSound playEffectSound = GetComponent<PlayEffectSound>();
        if (playEffectSound != null)
        {
            playEffectSound.Play();
            // 효과음 재생 시간만큼 대기 (효과음 길이에 맞게 조정하세요)
            yield return new WaitForSeconds(1); // 예시로 1초 대기
        }

        BgmSound bgmSound = bgmGameObject.GetComponent<BgmSound>();
        if (bgmSound != null)
        {
            bgmSound.Stop();
        }

        LoadingSceneController.LoadScene(nextScene);
    }
}
