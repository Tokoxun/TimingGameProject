using UnityEngine;

public class DisappearingTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.mrkDisap = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.mrkDisap = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
