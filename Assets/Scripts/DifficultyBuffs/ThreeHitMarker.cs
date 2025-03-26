using UnityEngine;

public class ThreeHitMarker : EffectTag
{
    public override void ActivateEffect()
    {
        currentLevel = 0;
        DifficultyManager.secondHit = true;
        // DifficultyManager.thirdHit = true;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        DifficultyManager.secondHit = false;
        DifficultyManager.thirdHit = false;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            DifficultyManager.thirdHit = true;
        }
    }
}
