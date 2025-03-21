using UnityEngine;

public class InputChangeTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.initInputChange = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.initInputChange = false;
    }
}
