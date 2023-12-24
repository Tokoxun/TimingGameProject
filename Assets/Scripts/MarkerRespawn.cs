using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRespawn : MonoBehaviour
{
    public GameObject mrk;
    public float respawnTime = 0.5f;
    public float respawnTimer;
    
    void Update()
    {
        if(!mrk.activeSelf)
        {
            MarkerSpinScript spnSpd = GetComponentInParent<MarkerSpinScript>();
            spnSpd.buffedSpnSpd = 0;
            respawnTimer += Time.deltaTime;
            if(respawnTimer >= respawnTime)
            {
                mrk.SetActive(true);
                respawnTimer = 0;
            }
        }
    }
}
