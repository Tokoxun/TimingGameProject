using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingHitter : MonoBehaviour
{
    void Start()
    {
        DifficultyManager.LongHitter = false;
        DifficultyManager.ShortHitter = true;
    }

}
