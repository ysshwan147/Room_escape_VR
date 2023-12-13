using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Canvas canvas; // 해당 물체에 연결된 Canvas

    void Update()
    {
        // 물체 위치에 따라 Canvas 위치 업데이트
        canvas.transform.position = transform.position;

        // UI를 항상 카메라 방향을 향하도록 회전 설정
        // canvas.transform.LookAt(playerCamera);
    }
}
