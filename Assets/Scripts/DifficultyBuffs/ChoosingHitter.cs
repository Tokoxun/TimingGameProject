using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingHitter : MonoBehaviour
{
    private bool choseShort = false;
    private bool choseLong = false;
    public void ShortChoice()
    {
        if(!choseShort && choseLong)
        {
            DifficultyManager.LongHitter = false;
            DifficultyManager.ShortHitter = true;
            choseShort = true;
            choseLong = false;
            return;
        }
        if(!choseShort)
        {
            DifficultyManager.ShortHitter = true;
            choseShort = true;
            return;
        }
        if(choseShort)
        {
            DifficultyManager.ShortHitter = false;
            choseShort = false;
            return;
        }
    }

    public void LongChoice()
    {
        if(!choseLong && choseShort)
        {
            DifficultyManager.LongHitter = true;
            DifficultyManager.ShortHitter = false;
            choseShort = false;
            choseLong = true;
            return;
        }
        if(!choseLong)
        {
            DifficultyManager.LongHitter = true;
            choseLong = true;
            return;
        }
        if(choseLong)
        {
            DifficultyManager.LongHitter = false;
            choseLong = false;
            return;
        }
    }
}
