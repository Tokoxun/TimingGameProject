using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwSpdUp : EffectTag
{
    private float SpdUp = 5f;
    public override void ActivateEffect()
    {
        DifficultyManager.addArwSpd += SpdUp;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.addArwSpd -= SpdUp;
    }
}
