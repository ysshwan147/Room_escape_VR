using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryScript : MonoBehaviour
{
    public TextMeshProUGUI storyText; // Text UI ��Ҹ� ������ ����
    public string[] storyMessages; // ���������� ����� �޽������� �迭�� ����

    private int currentIndex = 0; // ���� ��� ���� �޽����� �ε���

    void Start()
    {
        // �ʱ⿡�� ��� �ؽ�Ʈ�� ����ϴ�.
        storyText.text = "";
        ShowNextMessage();
    }

    void ShowNextMessage()
    {
        if (currentIndex < storyMessages.Length)
        {
            // ���� �޽��� ���
            storyText.text = storyMessages[currentIndex];
            currentIndex++;

            // ���� �ð� �Ŀ� ���� �޽����� �����ݴϴ�.
            Invoke("ShowNextMessage", 3f); // 2�� �Ŀ� ���� �޽��� ��� (���ϴ� �ð����� ���� ����)
        }
        else
        {
            // ��� �޽����� ����� �� ���ϴ� ���� ����
            Debug.Log("��� �޽��� ��� �Ϸ�!");
        }
    }
}

