using UnityEngine;

public class CanvasInteraction : MonoBehaviour
{
    public Transform objectToFollow; // ��ü(Transform)

    void Update()
    {
        // ��ü ��ġ�� ���� Canvas ��ġ ������Ʈ
        transform.position = objectToFollow.position;

        // UI�� �׻� ī�޶� ������ ���ϵ��� ȸ�� ���� (ī�޶� MainCamera�� ���)
       //  transform.LookAt(Camera.main.transform);
    }
}
