using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    public float totalRespawnTime;
    private float respawnTime = 0.5f;
    private float respawnTimer;
    private MarkerScript currentMarkRes;
    public MarkerSpinScript markRotation;

    void Start()
    {
        currentMarkRes = this.gameObject.GetComponent<MarkerScript>();
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
                markRotation.randomCurrentMarkPosition();
                currentMarkRes.Respawn();
                respawnTimer = 0;
            }
        }
    }
}
