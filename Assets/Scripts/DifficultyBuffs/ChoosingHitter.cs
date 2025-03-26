using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingHitter : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.LongHitter = false;
        DifficultyManager.ShortHitter = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.LongHitter = true;
        DifficultyManager.ShortHitter = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
