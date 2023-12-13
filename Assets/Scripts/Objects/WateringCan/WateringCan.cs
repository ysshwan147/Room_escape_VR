using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public GameObject particleSystemObject;
    public float maxAmount = 256.0f;
    public float minAngle = 30.0f;
    public float maxAngle = 60.0f;

    private ParticleSystem.EmissionModule particleEmission;

    // Start is called before the first frame update
    void Start()
    {
        particleEmission = particleSystemObject.GetComponent<ParticleSystem>().emission;

        wateringOff();
    }

    // Update is called once per frame
    void Update()
    {

        float angle = Vector3.Angle(Vector3.up, transform.up);

        if (angle <= minAngle)
        {
            particleEmission.rateOverTime = 0.0f;
        }
        else if (angle > minAngle && angle <= maxAngle)
        {
            var tempAngle = angle - minAngle;

            particleEmission.rateOverTime = tempAngle * (maxAmount / (maxAngle - minAngle));
        }
        else if (angle > maxAngle)
        {
            particleEmission.rateOverTime = maxAmount;
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
