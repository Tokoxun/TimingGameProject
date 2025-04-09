using UnityEngine;

public class MarkSpdUp : EffectTag
{
    private float actualSpdUpMrk;
    private float SpdUp;
    private float SpdUp_II;
    private float SpdUp_III;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        SpdUp = Random.Range(1, 51);
        actualSpdUpMrk = SpdUp;
        DifficultyManager.addMrkSpd += actualSpdUpMrk;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.addMrkSpd -= actualSpdUpMrk;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            SpdUp_II = Random.Range(60, 101);
            actualSpdUpMrk = SpdUp_II;
            DifficultyManager.addMrkSpd -= SpdUp;
            DifficultyManager.addMrkSpd += actualSpdUpMrk;
        }
        else if(currentLevel == 2)
        {
            SpdUp_III = Random.Range(100, 201);
            actualSpdUpMrk = SpdUp_III;
            DifficultyManager.addMrkSpd -= SpdUp_II;
            DifficultyManager.addMrkSpd += actualSpdUpMrk;
        }
    }
}
