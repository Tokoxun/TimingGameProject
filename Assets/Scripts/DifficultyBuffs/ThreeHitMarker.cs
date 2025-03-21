using UnityEngine;

public class ThreeHitMarker : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.secondHit = true;
        DifficultyManager.thirdHit = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.secondHit = false;
        DifficultyManager.thirdHit = false;
    }
}
