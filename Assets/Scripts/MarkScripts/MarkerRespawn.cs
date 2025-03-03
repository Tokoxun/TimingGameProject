using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    public GameObject mrk;
    public GameObject mrkShort;
    public float totalRespawnTime;
    private float respawnTime = 0.5f;
    private float respawnTimer;
    public MarkerScript markRes;
    public MarkerScript markResShort;
    public MarkerSpinScript markRotation;
    
    void Update()
    {
        totalRespawnTime = respawnTime + DifficultyManager.addMrkRespawn;
        if(!mrk.activeSelf && DifficultyManager.ShortMarker == false)
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
                markRes.Respawn();
                respawnTimer = 0;
            }
        }
        else if(!mrkShort.activeSelf && DifficultyManager.ShortMarker == true)
        {
            respawnTimer += Time.deltaTime;
            if(respawnTimer >= totalRespawnTime)
            {
                markRotation.randomCurrentMarkPosition();
                markResShort.Respawn();
                respawnTimer = 0;
            }
        }
    }
}
