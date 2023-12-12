using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class UIController : MonoBehaviour
{
    public XRBaseInteractable interactable; // XR Interactable ����
    public CanvasGroup canvasGroup; // ĵ���� �׷� (Fade-In/Fade-Out�� ����)
    public float fadeDuration = 0.5f; // Fade-In/Fade-Out ���� �ð�
    private Coroutine currentCoroutine;

    private void Awake()
    {
        // �̺�Ʈ�� ���� �ݹ� �Լ� �߰�
        interactable.onHoverEntered.AddListener(OnHoverEntered);
        interactable.onHoverExited.AddListener(OnHoverExited);

        // Canvas �ʱ� ���� ����
        canvasGroup.alpha = 0f; // ó������ ���� �����ϰ� ����
        canvasGroup.interactable = false; // ��ȣ�ۿ� �Ұ����ϵ��� ����
        canvasGroup.blocksRaycasts = false; // ����ĳ��Ʈ ���� ����
    }

    void OnHoverEntered(XRBaseInteractor interactor)
    {
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(FadeCanvasGroup(canvasGroup, 0f, 1f, fadeDuration));
    }

    void OnHoverExited(XRBaseInteractor interactor)
    {
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(FadeCanvasGroup(canvasGroup, 1f, 0f, fadeDuration));
    }

    IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration)
    {
        float startTime = Time.time;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime = Time.time - startTime;
            float percentageComplete = elapsedTime / duration;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, percentageComplete);
            yield return null;
        }

        canvasGroup.alpha = endAlpha;

        if (endAlpha == 0f)
        {
            canvasGroup.interactable = false; // ��ȣ�ۿ� �Ұ����ϰ� ����
            canvasGroup.blocksRaycasts = false; // ����ĳ��Ʈ ���� ����
        }
        else
        {
            canvasGroup.interactable = true; // ��ȣ�ۿ� �����ϰ� ����
            canvasGroup.blocksRaycasts = true; // ����ĳ��Ʈ ��� ����
        }
    }
}
