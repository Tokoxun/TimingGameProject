using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private float dirChangeTime = 2f;
    public float changeTime;
    public float spinSpeed = -50f;
    private float[] changeOrNot;

    void Start()
    {
        changeOrNot = new float[2];
        changeOrNot[0] = spinSpeed;
        changeOrNot[1] = -spinSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        changeTime += Time.deltaTime;
        if(changeTime >= dirChangeTime)
        {
            spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
            changeTime = 0;
        }
    }  
}
