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
    public Animator orangeMarkAnim;
    public Animator purpleMarkAnim;

    // Update is called once per frame
    void Update()
    {
        if(DifficultyManager.mrkDisap)
        {
            AppearTime += Time.deltaTime;
            if(AppearTime >= timeToAppear)
            {
                purpleMarkAnim.SetBool("Fade", true);
                orangeMarkAnim.SetBool("Fade", true);
                markAnim.SetBool("Fade", true);
                DisapTimer += Time.deltaTime;
                if(DisapTimer >= DurOfDisap)
                {
                    purpleMarkAnim.SetBool("Fade", false);
                    orangeMarkAnim.SetBool("Fade", false);
                    markAnim.SetBool("Fade", false);
                    AppearTime = 0;
                    DisapTimer = 0;
                } 
            }
        }
    }
}
