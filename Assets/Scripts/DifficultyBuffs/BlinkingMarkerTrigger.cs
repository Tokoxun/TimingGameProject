using UnityEngine;

public class BlinkingMarkerTrigger : EffectTag
{
    private float increaseEffect_I = 0.3f;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.mrkBlink = true;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        BlinkingMarkScript.DecreaseBlinking(increaseEffect_I);
        DifficultyManager.mrkBlink = false;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            BlinkingMarkScript.IncreaseBlinking(increaseEffect_I);
        }
    }
}
