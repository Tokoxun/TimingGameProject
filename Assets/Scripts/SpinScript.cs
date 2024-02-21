using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private float dirChangeTime = 1f;
    public float changeTime;
    public float spinSpeed = -50f;
    private float[] changeOrNot;

    void Start()
    {
        spinSpeed -= DifficultyManager.addArwSpd;
        changeOrNot = new float[3];
        changeOrNot[0] = spinSpeed;
        changeOrNot[1] = -spinSpeed;
        changeOrNot[2] = spinSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        // Quaternion rotation = transform.rotation;

        // // Extract the Z-axis rotation angle
        // float zRotation = rotation.eulerAngles.z;

        // // Output the rotation angle
        // Debug.Log("Z-axis rotation: " + zRotation);
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        changeTime += Time.deltaTime;
        if(changeTime >= dirChangeTime)
        {
            spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
            changeTime = 0;
        }
    }  
}
