using UnityEngine;

public class ButtonCooldown : EffectTag
{
    private float actualButtonCooldown;
    private float frstCooldown = 2f;
    private float scdCooldown = 4f;
    private float trdCooldown = 8f;
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        actualButtonCooldown = frstCooldown;
        DifficultyManager.addButtonCooldown += actualButtonCooldown;
        Debug.Log(DifficultyManager.addButtonCooldown);
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        DifficultyManager.addButtonCooldown -= actualButtonCooldown;
        Debug.Log(DifficultyManager.addButtonCooldown);
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            DifficultyManager.addButtonCooldown -= actualButtonCooldown;
            actualButtonCooldown = scdCooldown;
            DifficultyManager.addButtonCooldown += actualButtonCooldown;
            Debug.Log(DifficultyManager.addButtonCooldown);
        }
        else if(currentLevel == 2)
        {
            DifficultyManager.addButtonCooldown -= actualButtonCooldown;
            actualButtonCooldown = trdCooldown;
            DifficultyManager.addButtonCooldown += actualButtonCooldown;
            Debug.Log(DifficultyManager.addButtonCooldown);
        }
    }
}
