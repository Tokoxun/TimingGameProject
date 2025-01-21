using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;
    public void markSpdUp()
    {
        MarkerSpinScript spinningSpeed = Object.FindFirstObjectByType<MarkerSpinScript>();
        if(spinningSpeed != null)
        {
            spinningSpeed.buffedSpnSpd += spinningSpeed.spinSpeed - SpdUp;
        }
    }
}
