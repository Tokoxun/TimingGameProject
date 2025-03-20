using UnityEngine;

public class TimerTrigger : EffectTag
{
    public static bool startTimer = false;
    public override void ActivateEffect()
    {
        if(!activatedEffect)
        {
            startTimer = true;
            activatedEffect = true;
        }
    }

    public override void RemoveEffect()
    {
        throw new System.NotImplementedException();
    }
}