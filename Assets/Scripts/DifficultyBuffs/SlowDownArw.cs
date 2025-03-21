using UnityEngine;

public class SlowDownArw : EffectTag
{
    private float SpdDwn = 5f;
    public override void ActivateEffect()
    {
        DifficultyManager.decreaseArwSpd += SpdDwn;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.decreaseArwSpd -= SpdDwn;
    }
}
