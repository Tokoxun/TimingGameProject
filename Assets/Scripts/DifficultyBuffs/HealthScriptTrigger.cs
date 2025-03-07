using UnityEngine;

public class HealthScriptTrigger : EffectTag
{
    public static bool startHealth = false;
    public override void ActivateEffect()
    {
        startHealth = true;
        Debug.Log("Health");
    }
}
