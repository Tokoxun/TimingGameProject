using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    public GameObject mrk;
    public float totalRespawnTime;
    private float respawnTime = 0.5f;
    private float respawnTimer;
    public MarkerScript markRes;
    public MarkerSpinScript markRotation;
    
    void Update()
    {
        if(!mrk.activeSelf)
        {
            totalRespawnTime = respawnTime + DifficultyManager.addMrkRespawn;
            DisappearingScript resetDisap = GetComponent<DisappearingScript>();
            if(resetDisap != null)
            {
                resetDisap.AppearTime = 0;
            }
            respawnTimer += Time.deltaTime;
            if(respawnTimer >= totalRespawnTime)
            {
                markRotation.randomCurrentMarkPosition();
                markRes.Respawn();
                mrk.SetActive(true);
                respawnTimer = 0;
            }
        }
    }
}
