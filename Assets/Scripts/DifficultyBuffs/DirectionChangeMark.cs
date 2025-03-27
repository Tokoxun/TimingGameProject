using UnityEngine;

public class DirectionChangeMark : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.rotateMarker = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.rotateMarker = false;
    }
    public override void EnchanceEffect()
    {
        throw new System.NotImplementedException();
    }
}
