using UnityEngine;

public class BlinkingMarkerTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.mrkBlink = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.mrkBlink = false;
    }
}
