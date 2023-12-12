using System.Collections.Generic;
using UnityEngine;

public class DryFloor : MonoBehaviour
{
    public Material wetMat;
    public HiddenSpaceAnchor hiddenSpaceAnchor;

    private MeshRenderer screenRenderer = null;
    private List<ParticleCollisionEvent> collisionEvents;

    private int waterCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
        screenRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waterCount >= 500)
        {
            screenRenderer.material = wetMat;

            hiddenSpaceAnchor.openTrigger();

            enabled = false;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        var part = other.GetComponent<ParticleSystem>();
        int numCollisionEvents = ParticlePhysicsExtensions.GetCollisionEvents(part, gameObject, collisionEvents);

        waterCount += numCollisionEvents;
    }
}
