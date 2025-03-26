using UnityEngine;

public class ChoosingMarker : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.ShortMarker = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.ShortMarker = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
