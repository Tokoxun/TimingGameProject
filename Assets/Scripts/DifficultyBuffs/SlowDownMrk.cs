using UnityEngine;

public class SlowDownMrk : EffectTag
{
    private float SpdDownMrk = 5f;
    public override void ActivateEffect()
    {
        DifficultyManager.decreaseMrkSpd += SpdDownMrk;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.decreaseMrkSpd -= SpdDownMrk;
    }
}
