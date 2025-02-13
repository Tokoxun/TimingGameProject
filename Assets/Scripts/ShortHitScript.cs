using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortHitScript : MonoBehaviour
{
    public bool hitted = false;
    private bool missed = true;
    public float numOfMissed;
    private float hitReset = 0.2f;
    private float resetTimer;
    public Collider2D hitPoint;
    public DisplayCombo calCombo;
    public PointSystem addingPoint;
    public HealthScript calHealth;

    // public void OnButtonPressShort()
    // {
    //     hitPoint.enabled = true;
    //     hitted = true;
    // }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("target"))
        {
            addingPoint.AddPoint();
            missed = false;
        }
    }

    void Update()
    {
        if(hitted)
        {
            resetTimer += Time.deltaTime;
            if(resetTimer >= hitReset && missed == false)
            {
                calCombo.AddCombo();
                hitPoint.enabled = false;
                resetTimer = 0;
                hitted = false;
                missed = true;
            }
            if(resetTimer >= hitReset && missed == true)
            {
                calCombo.ResetCombo();
                calHealth.ReduceHealth();
                numOfMissed += 1;
                hitPoint.enabled = false;
                resetTimer = 0;
                hitted = false;
                Debug.Log(numOfMissed);
            }
        }
    }
}
