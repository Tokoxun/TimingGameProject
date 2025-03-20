using UnityEngine;

public class HealthScriptTrigger : EffectTag
{
    public static bool startHealth = false;
    public override void ActivateEffect()
    {
        if(!activatedEffect)
        {
            startHealth = true;
            activatedEffect = true;
        }
    }

    public override void RemoveEffect()
    {
        throw new System.NotImplementedException();
    }
}