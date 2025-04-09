using UnityEngine;

public class SlowDownMrk : EffectTag
{
    private float actualSpdDwnMrk;
    private float SpdDownMrk = 5f;
    private float SpdDownMrk_II = 10f;
    private float SpdDownMrk_III = 20f;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        actualSpdDwnMrk = SpdDownMrk;
        DifficultyManager.decreaseMrkSpd += actualSpdDwnMrk;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.decreaseMrkSpd -= actualSpdDwnMrk;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            actualSpdDwnMrk = SpdDownMrk_II;
            DifficultyManager.decreaseMrkSpd -= SpdDownMrk;
            DifficultyManager.decreaseMrkSpd += actualSpdDwnMrk;
        }
        else if(currentLevel == 2)
        {
            actualSpdDwnMrk = SpdDownMrk_III;
            DifficultyManager.decreaseMrkSpd -= SpdDownMrk_II;
            DifficultyManager.decreaseMrkSpd += actualSpdDwnMrk;
        }
    }
}
