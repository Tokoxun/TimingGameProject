using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    private bool hitted = false;
    private float hitReset = 0.2f;
    private float resetTimer;
    public BoxCollider2D hitPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        hitPoint.enabled = false;
    }

    public void OnButtonPress()
    {
        hitPoint.enabled = true;
        hitted = true;
        Debug.Log("activated");
    }

    void Update()
    {
        if(hitted)
        {
            resetTimer += Time.deltaTime;
            if(resetTimer >= hitReset)
            {
                hitPoint.enabled = false;
                resetTimer = 0;
                hitted = false;
            }
        }
    }
}
