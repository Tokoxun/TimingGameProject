using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    public GameObject mrk;
    public float respawnTime = 0.5f;
    private float respawnTimer;
    
    void Update()
    {
        if(!mrk.activeSelf)
        {
            DisappearingScript resetDisap = GetComponent<DisappearingScript>();
            if(resetDisap != null)
            {
                resetDisap.AppearTime = 0;
            }
            respawnTimer += Time.deltaTime;
            if(respawnTimer >= respawnTime)
            {
                mrk.SetActive(true);
                respawnTimer = 0;
            }
        }
    }
}
