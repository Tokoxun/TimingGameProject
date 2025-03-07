using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingHitter : MonoBehaviour
{
    void OnEnable()
    {
        DifficultyManager.LongHitter = false;
        DifficultyManager.ShortHitter = true;
    }

    void OnDisable()
    {
        DifficultyManager.LongHitter = true;
        DifficultyManager.ShortHitter = false;
    }
}
