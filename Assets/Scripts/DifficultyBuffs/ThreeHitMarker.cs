using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeHitMarker : MonoBehaviour
{
    private bool toggled = false;
    public void ThreeHitSelect()
    {
        if(!toggled)
        {
            DifficultyManager.secondHit = true;
            DifficultyManager.thirdHit = true;
            toggled = true;
            return;
        }
        if(toggled)
        {
            DifficultyManager.secondHit = false;
            DifficultyManager.thirdHit = false;
            toggled = false;
            return;
        }
    }
}
