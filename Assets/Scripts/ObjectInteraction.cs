using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Canvas canvas; // �ش� ��ü�� ����� Canvas

    void Update()
    {
        // ��ü ��ġ�� ���� Canvas ��ġ ������Ʈ
        canvas.transform.position = transform.position;

        // UI�� �׻� ī�޶� ������ ���ϵ��� ȸ�� ����
        // canvas.transform.LookAt(playerCamera);
    }
}
