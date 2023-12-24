using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;
    public void arwSpdUp()
    {
        SpinScript spinningSpeed = FindObjectOfType<SpinScript>();
        if(spinningSpeed != null)
        {
            spinningSpeed.spinSpeed -= SpdUp;
        }
    }
}
