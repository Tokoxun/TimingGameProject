using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;

    void OnEnable()
    {
        DifficultyManager.addArwSpd += SpdUp;
    }

    void OnDisable()
    {
        DifficultyManager.addArwSpd -= SpdUp;
    }
}
