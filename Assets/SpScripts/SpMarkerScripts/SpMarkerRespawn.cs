using UnityEngine;

public class SpMarkerRespawn : MonoBehaviour
{
    public SpMarkerScript spMarkerScript;
    public delegate void RespawnItem();
    public RespawnItem triggerRespawn;
    [SerializeField] private float markCooldownTimer = 1f;
    [SerializeField] private float markCooldown;

    // Update is called once per frame
    void Update()
    {
        if (spMarkerScript.onHitted)
        {
            markCooldown += Time.deltaTime;
            if (markCooldown >= markCooldownTimer)
            {
                markCooldown = 0;
                triggerRespawn();
            }
        }
    }

    public void randomizeCooldown()
    {
        int cooldownRandom = Random.Range(0, 3);
        markCooldownTimer = cooldownRandom;
    }
}
