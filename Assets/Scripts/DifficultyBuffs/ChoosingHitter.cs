using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingHitter : MonoBehaviour
{
    private bool choseShort = false;
    public void ShortChoice()
    {
        if(!choseShort)
        {
            DifficultyManager.LongHitter = false;
            DifficultyManager.ShortHitter = true;
            choseShort = true;
            return;
        }
        if(choseShort)
        {
            DifficultyManager.LongHitter = true;
            DifficultyManager.ShortHitter = false;
            choseShort = false;
            return;
        }
    }
}
