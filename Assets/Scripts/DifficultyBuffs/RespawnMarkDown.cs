using UnityEngine;

public class RespawnMarkDown : EffectTag
{
    private float decreaseMrkRespawn = 1f;
    public override void ActivateEffect()
    {
        DifficultyManager.addMrkRespawn += decreaseMrkRespawn;
    }
    public override void RemoveEffect()
    {
        DifficultyManager.addMrkRespawn -= decreaseMrkRespawn;
    }
}
