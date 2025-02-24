using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;
    void OnEnable()
    {
        DifficultyManager.addMrkSpd += SpdUp;
    }

    void OnDisable()
    {
        DifficultyManager.addArwSpd -= SpdUp;
    }
    // public void markSpdUp()
    // {
    //     MarkerSpinScript spinningSpeed = Object.FindFirstObjectByType<MarkerSpinScript>();
    //     if(spinningSpeed != null)
    //     {
    //         spinningSpeed.buffedSpnSpd += spinningSpeed.spinSpeed - SpdUp;
    //     }
    // }
}
