using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : EffectTag
{
    public static bool startTimer = false;

    public override void ActivateEffect()
    {
        startTimer = true;
        Debug.Log("Timer");
    }
}
