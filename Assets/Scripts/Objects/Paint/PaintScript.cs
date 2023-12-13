using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintScript : MonoBehaviour
{
    public GameObject objectToActivate; // Ȱ��ȭ�� ������Ʈ

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
            // ��� �ð� ���� ��� (����� Ŭ���� ���̿� ���� �����ϼ���)
            yield return new WaitForSeconds(1); // ���÷� 1�� ���
        }

        gameObject.SetActive(false); // �� �ڽ��� ��Ȱ��ȭ
        collidedObject.SetActive(false); // �浹�� ������Ʈ�� ��Ȱ��ȭ

        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }
}
