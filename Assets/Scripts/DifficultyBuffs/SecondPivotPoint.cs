using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPivotPoint : MonoBehaviour
{
    private bool toggled = false;

    public void SecondPivotPointOrCancel()
    {
        if(!toggled)
        {
            DifficultyManager.secondPivotPoint = true;
            toggled = true;
            return;
        }
        if(toggled)
        {
            DifficultyManager.secondPivotPoint = false;
            toggled = false;
            return;
        }
    }
}
