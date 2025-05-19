using UnityEngine;

public class RespawnMarkDown : EffectTag
{
    private float actualDecrease;
    [SerializeField] private float decreaseMrkRespawn_I = 5f;
    [SerializeField] private float decreaseMrkRespawn_II = 10f;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        actualDecrease = decreaseMrkRespawn_I;
        DifficultyManager.addMrkRespawn = actualDecrease;
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.addMrkRespawn -= actualDecrease;
        actualDecrease = 0;
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            actualDecrease += decreaseMrkRespawn_II;
            DifficultyManager.addMrkRespawn = actualDecrease;
        }
    }
}
