using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeHitMarker : MonoBehaviour
{
    void OnEnable()
    {
        DifficultyManager.secondHit = true;
        DifficultyManager.thirdHit = true;
    }

    void OnDisable()
    {
        DifficultyManager.secondHit = false;
        DifficultyManager.thirdHit = false;
    }
}
