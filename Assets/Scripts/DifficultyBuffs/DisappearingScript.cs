using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingScript : MonoBehaviour
{
    public float timeToAppear = 2f;
    public float AppearTime;
    public float DurOfDisap = 2f;
    private float DisapTimer;
    public SpriteRenderer mrk;

    // Update is called once per frame
    void Update()
    {
        AppearTime += Time.deltaTime;
        if(AppearTime >= timeToAppear)
        {
            mrk.enabled = false;
            DisapTimer += Time.deltaTime;
            if(DisapTimer >= DurOfDisap)
            {
                mrk.enabled = true;
                AppearTime = 0;
                DisapTimer = 0;
            } 
        }
    }
}
