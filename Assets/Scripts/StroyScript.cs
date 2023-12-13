using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryScript : MonoBehaviour
{
    public TextMeshProUGUI storyText; // Text UI 요소를 참조할 변수
    public string[] storyMessages; // 순차적으로 출력할 메시지들을 배열로 저장

    private int currentIndex = 0; // 현재 출력 중인 메시지의 인덱스

    void Start()
    {
        // 초기에는 모든 텍스트를 숨깁니다.
        storyText.text = "";
        ShowNextMessage();
    }

    void ShowNextMessage()
    {
        if (currentIndex < storyMessages.Length)
        {
            // 다음 메시지 출력
            storyText.text = storyMessages[currentIndex];
            currentIndex++;

            // 일정 시간 후에 다음 메시지를 보여줍니다.
            Invoke("ShowNextMessage", 3f); // 2초 후에 다음 메시지 출력 (원하는 시간으로 변경 가능)
        }
        else
        {
            // 모든 메시지를 출력한 후 원하는 동작 수행
            Debug.Log("모든 메시지 출력 완료!");
        }
    }
}

