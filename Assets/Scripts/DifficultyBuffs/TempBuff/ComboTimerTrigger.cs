using UnityEngine;

public class ComboTimerTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        ComboTimer.SetTimer(5f);
    }
    public override void RemoveEffect()
    {
        ComboTimer.SetTimer(0);
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
