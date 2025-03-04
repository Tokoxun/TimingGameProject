using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingScript : MonoBehaviour
{
    public float timeToAppear = 2f;
    public float AppearTime;
    public float DurOfDisap = 2f;
    private float DisapTimer;
    public Animator markAnim;

    // Update is called once per frame
    void Update()
    {
        if(DifficultyManager.mrkDisap)
        {
            AppearTime += Time.deltaTime;
            if(AppearTime >= timeToAppear)
            {
                markAnim.SetBool("Fade", true);
                DisapTimer += Time.deltaTime;
                if(DisapTimer >= DurOfDisap)
                {
                    markAnim.SetBool("Fade", false);
                    AppearTime = 0;
                    DisapTimer = 0;
                } 
            }
        }
    }
}
