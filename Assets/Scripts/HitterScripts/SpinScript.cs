using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    private float dirChangeTime = 1f;
    public float changeTime;
    public float spinSpeed = -100f;
    private float[] changeOrNot;
    public float buffedSpnSpd;
    public float totalBuffedSpnSpd;
    public LevelManager levelBuff;
    public float levelbuffedSpnSpd;

    void Start()
    {
        changeOrNot = new float[2];
    }
    // Update is called once per frame
    void Update()
    {
        // Quaternion rotation = transform.rotation;

        // // Extract the Z-axis rotation angle
        // float zRotation = rotation.eulerAngles.z;

        // // Output the rotation angle
        // Debug.Log("Z-axis rotation: " + zRotation);
        buffedSpnSpd = (DifficultyManager.addArwSpd - DifficultyManager.decreaseArwSpd) / 100;
        totalBuffedSpnSpd = spinSpeed * buffedSpnSpd;
        levelbuffedSpnSpd = spinSpeed * levelBuff.levelSpeed;
        transform.Rotate(Vector3.forward * (spinSpeed + totalBuffedSpnSpd + levelbuffedSpnSpd) * Time.deltaTime);
        if(changeOrNot != null  && DifficultyManager.rotateHitter)
        {
            changeOrNot[0] = spinSpeed;
            changeOrNot[1] = -spinSpeed;
            changeTime += Time.deltaTime;
            if(changeTime >= dirChangeTime)
            {
                spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
                changeTime = 0;
            }
        }
    }
}
