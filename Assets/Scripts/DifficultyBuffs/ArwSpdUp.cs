using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;

    void Start()
    {
        DifficultyManager.addArwSpd += SpdUp;
    }
}
