using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSpinScript : MonoBehaviour
{
    public float spinSpeed = -35f;
    public float buffedSpnSpd;

    // Update is called once per frame
    void Update()
    {
        if(buffedSpnSpd != 0)
        {
            transform.Rotate(Vector3.forward * buffedSpnSpd * Time.deltaTime);
        }
        if( buffedSpnSpd == 0)
        {
            transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        }
    }
}
