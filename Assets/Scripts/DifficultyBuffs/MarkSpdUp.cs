using UnityEngine;

public class MarkSpdUp : EffectTag
{
    private float SpdUp = 5f;
    public override void ActivateEffect()
    {
        DifficultyManager.addMrkSpd += SpdUp;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.addMrkSpd -= SpdUp;
    }
}
