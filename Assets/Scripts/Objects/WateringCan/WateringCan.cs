using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public GameObject particleSystemObject;
    public float maxAmount = 256.0f;
    public float minAngle = 30.0f;
    public float maxAngle = 60.0f;

    private ParticleSystem.EmissionModule particleEmission;
    private AudioSource audioSource;
    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        particleEmission = particleSystemObject.GetComponent<ParticleSystem>().emission;
        audioSource = GetComponent<AudioSource>();

        wateringOff();
    }

    // Update is called once per frame
    void Update()
    {

        float angle = Vector3.Angle(Vector3.up, transform.up);

        if (angle <= minAngle)
        {
            particleEmission.rateOverTime = 0.0f;

            if (isPlaying)
            {
                audioSource.Stop();
                isPlaying = false;
            }
        }
        else if (angle > minAngle && angle <= maxAngle)
        {
            var tempAngle = angle - minAngle;

            particleEmission.rateOverTime = tempAngle * (maxAmount / (maxAngle - minAngle));

            if (!isPlaying)
            {
                audioSource.Play();
                isPlaying = true;
            }
        }
        else if (angle > maxAngle)
        {
            particleEmission.rateOverTime = maxAmount;

            if (!isPlaying)
            {
                audioSource.Play();
                isPlaying = true;
            }
        }
    }

    public void wateringOn()
    {
        particleSystemObject.SetActive(true);
    }

    public void wateringOff()
    {
        particleSystemObject.SetActive(false);
    }
}
