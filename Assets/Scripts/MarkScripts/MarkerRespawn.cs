using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    delegate void RespawnItem();
    RespawnItem triggerRespawn;
    public float totalRespawnTime;
    private float respawnTime = 1f;
    private float respawnTimer;
    private MarkerScript currentMarkRes;
    public MarkerSpinScript markRotation;

    void Start()
    {
        currentMarkRes = this.gameObject.GetComponent<MarkerScript>();
        triggerRespawn += currentMarkRes.Respawn;
        triggerRespawn += markRotation.randomCurrentMarkPosition;
        triggerRespawn += VariableHit.randomVariable;
    }
    void Update()
    {
        totalRespawnTime = respawnTime + DifficultyManager.addMrkRespawn;
        if(currentMarkRes.onHitted == true)
        {
            // DisappearingScript resetDisap = GetComponent<DisappearingScript>();
            // if(resetDisap != null)
            // {
            //     resetDisap.AppearTime = 0;
            // }
            respawnTimer += Time.deltaTime;
            if(respawnTimer >= totalRespawnTime)
            {
                triggerRespawn();
                respawnTimer = 0;
            }
        }
    }
}
