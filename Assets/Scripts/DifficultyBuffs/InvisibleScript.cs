using UnityEngine;

public class InvisibleScript : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.displayHitterSprite = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.displayHitterSprite = false;
    }
}
