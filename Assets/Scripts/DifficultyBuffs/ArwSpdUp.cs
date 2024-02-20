using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwSpdUp : MonoBehaviour
{
    private float SpdUp = 5f;
    private bool toggled = false;

    public void AddSpdOrCancel()
    {
        if(toggled == false)
        {
            DifficultyManager.addArwSpd += SpdUp;
            toggled = true;
            return;
        }
        if(toggled == true)
        {
            DifficultyManager.addArwSpd -= SpdUp;
            toggled = false;
            return;
        }
    }
}
