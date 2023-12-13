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
            // ȿ���� ��� �ð���ŭ ��� (ȿ���� ���̿� �°� �����ϼ���)
            yield return new WaitForSeconds(1); // ���÷� 1�� ���
        }

        BgmSound bgmSound = bgmGameObject.GetComponent<BgmSound>();
        if (bgmSound != null)
        {
            bgmSound.Stop();
        }

        LoadingSceneController.LoadScene(nextScene);
    }
}
