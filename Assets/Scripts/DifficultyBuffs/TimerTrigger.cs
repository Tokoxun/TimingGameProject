using UnityEngine;

public class TimerTrigger : EffectTag
{
    public static bool startTimer = false;
    public override void ActivateEffect()
    {
        startTimer = true;
    }

    public override void RemoveEffect()
    {
        startTimer = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}