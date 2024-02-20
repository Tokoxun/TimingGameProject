using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHitMarker : MonoBehaviour
{
    private bool toggled = false;
    public void SecondHitOrCancel()
    {
        if(!toggled)
        {
            DifficultyManager.secondHit = true;
            toggled = true;
            return;
        }
        if(toggled)
        {
            DifficultyManager.secondHit = false;
            toggled = false;
            return;
        }
    }
}
