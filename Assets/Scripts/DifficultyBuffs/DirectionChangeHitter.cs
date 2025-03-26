using UnityEngine;

public class DirectionChangeHitter : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.rotateHitter = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.rotateHitter = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
