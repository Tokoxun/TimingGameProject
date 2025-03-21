using UnityEngine;

public class ButtonCooldown : EffectTag
{
    private float frstCooldown = 2f;
    public override void ActivateEffect()
    {
        DifficultyManager.addButtonCooldown += frstCooldown;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.addButtonCooldown -= frstCooldown;
    }
}
