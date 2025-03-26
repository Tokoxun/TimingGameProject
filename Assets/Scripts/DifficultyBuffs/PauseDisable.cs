using UnityEngine;

public class PauseDisable : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.disablePause = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.disablePause = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
