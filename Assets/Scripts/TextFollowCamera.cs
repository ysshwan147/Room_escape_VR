using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextFollowCamera : MonoBehaviour
{
    public Camera playerCamera; // ����ڰ� ���� ī�޶�

    void Update()
    {
        // ī�޶��� ��ġ�� ȸ������ �������� �ؽ�Ʈ ������Ʈ
        transform.position = playerCamera.transform.position + playerCamera.transform.forward; // ���÷� ī�޶󿡼� ���� �Ÿ� �տ� ��ġ

        // ī�޶��� ������ �����ͼ� �ؽ�Ʈ�� �ٶ󺸰� ����
        transform.rotation = Quaternion.LookRotation(playerCamera.transform.forward, playerCamera.transform.up);
    }
}


