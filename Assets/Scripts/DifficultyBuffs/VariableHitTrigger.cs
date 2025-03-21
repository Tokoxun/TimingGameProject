using UnityEngine;

public class VariableHitTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.displayVariableNum = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.displayVariableNum = false;
    }
}
