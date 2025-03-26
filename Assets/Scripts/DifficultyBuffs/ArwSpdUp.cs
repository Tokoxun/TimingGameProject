using UnityEngine;

public class ArwSpdUp : EffectTag
{
    private float actualSpdUp;
    private float SpdUp_I;
    private float SpdUp_II;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        SpdUp_I = Random.Range(1, 51);
        actualSpdUp = SpdUp_I;
        DifficultyManager.addArwSpd += actualSpdUp;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.addArwSpd -= actualSpdUp;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            SpdUp_II = Random.Range(60, 101);
            actualSpdUp = SpdUp_II;
            DifficultyManager.addArwSpd -= SpdUp_I;
            DifficultyManager.addArwSpd += actualSpdUp;
        }
    }
}
