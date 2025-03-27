using UnityEngine;

public class SlowDownArw : EffectTag
{
    private float actualSpdDwnArw;
    private float SpdDwn = 5f;
    private float SpdDwn_II = 10f;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        actualSpdDwnArw = SpdDwn;
        DifficultyManager.decreaseArwSpd += actualSpdDwnArw;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.decreaseArwSpd -= SpdDwn;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            actualSpdDwnArw = SpdDwn_II;
            DifficultyManager.decreaseArwSpd -= SpdDwn;
            DifficultyManager.decreaseArwSpd += actualSpdDwnArw;
        }
    }
}
