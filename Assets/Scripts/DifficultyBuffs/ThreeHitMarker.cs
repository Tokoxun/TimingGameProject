using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeHitMarker : MonoBehaviour
{
    void Start()
    {
        DifficultyManager.secondHit = true;
        DifficultyManager.thirdHit = true;
    }
}
