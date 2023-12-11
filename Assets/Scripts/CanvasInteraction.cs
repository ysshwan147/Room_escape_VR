using UnityEngine;

public class CanvasInteraction : MonoBehaviour
{
    public Transform objectToFollow; // 물체(Transform)

    void Update()
    {
        // 물체 위치에 따라 Canvas 위치 업데이트
        transform.position = objectToFollow.position;

        // UI를 항상 카메라 방향을 향하도록 회전 설정 (카메라가 MainCamera인 경우)
       //  transform.LookAt(Camera.main.transform);
    }
}
