using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeHitMarker : MonoBehaviour
{
    private bool toggled = true;

    void Update()
    {
        if(toggled)
        {
            DifficultyManager.secondHit = true;
            DifficultyManager.thirdHit = true;
        }
    }
    // public void ThreeHitSelect()
    // {
    //     if(!toggled)
    //     {
    //         DifficultyManager.secondHit = true;
    //         DifficultyManager.thirdHit = true;
    //         DispR.sprite = TargetImg;
    //         toggled = true;
    //         return;
    //     }
    //     if(toggled)
    //     {
    //         DifficultyManager.secondHit = false;
    //         DifficultyManager.thirdHit = false;
    //         DispR.sprite = null;
    //         toggled = false;
    //         return;
    //     }
    // }
}
