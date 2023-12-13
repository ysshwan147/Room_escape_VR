using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class UIController : MonoBehaviour
{
    public XRBaseInteractable interactable; // XR Interactable 연결
    public CanvasGroup canvasGroup; // 캔버스 그룹 (Fade-In/Fade-Out에 사용됨)
    public float fadeDuration = 0.5f; // Fade-In/Fade-Out 지속 시간
    private Coroutine currentCoroutine;

    private void Awake()
    {
        // 이벤트에 대한 콜백 함수 추가
        interactable.onHoverEntered.AddListener(OnHoverEntered);
        interactable.onHoverExited.AddListener(OnHoverExited);

        // Canvas 초기 상태 설정
        canvasGroup.alpha = 0f; // 처음에는 완전 투명하게 설정
        canvasGroup.interactable = false; // 상호작용 불가능하도록 설정
        canvasGroup.blocksRaycasts = false; // 레이캐스트 차단 설정
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
            canvasGroup.interactable = false; // 상호작용 불가능하게 설정
            canvasGroup.blocksRaycasts = false; // 레이캐스트 차단 설정
        }
        else
        {
            canvasGroup.interactable = true; // 상호작용 가능하게 설정
            canvasGroup.blocksRaycasts = true; // 레이캐스트 허용 설정
        }
    }
}
