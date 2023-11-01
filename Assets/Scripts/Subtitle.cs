using System.Collections;
using UnityEngine;

public class Subtitle : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Time before destroying in seconds.")]
    float m_Lifetime = 5f;

    [SerializeField]
    Subtitle nextSubtitle;


    void OnEnable()
    {
        StartCoroutine(DisableAfterDelay(m_Lifetime));
    }

    IEnumerator DisableAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        if (nextSubtitle != null)
        {
            nextSubtitle.gameObject.SetActive(true);
        }
    }
}
