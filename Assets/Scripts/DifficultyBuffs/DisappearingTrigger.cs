using UnityEngine;

public class DisappearingTrigger : EffectTag
{
    public override void ActivateEffect()
    {
        DifficultyManager.mrkDisap = true;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.mrkDisap = false;
    }
    void OnEnable()
    {
        DifficultyManager.mrkDisap = true;
    }

    void OnDisable()
    {
        DifficultyManager.mrkDisap = false;
    }
}
