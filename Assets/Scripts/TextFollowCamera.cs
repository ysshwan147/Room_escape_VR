using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextFollowCamera : MonoBehaviour
{
    public Camera playerCamera; // 사용자가 보는 카메라

    void Update()
    {
        // 카메라의 위치와 회전값을 기준으로 텍스트 업데이트
        transform.position = playerCamera.transform.position + playerCamera.transform.forward*0.5f; // 예시로 카메라에서 일정 거리 앞에 배치

        // 카메라의 방향을 가져와서 텍스트가 바라보게 설정
        transform.rotation = Quaternion.LookRotation(playerCamera.transform.forward, playerCamera.transform.up);
    }
}


