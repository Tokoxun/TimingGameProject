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
}
