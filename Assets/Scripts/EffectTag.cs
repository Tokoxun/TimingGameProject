using UnityEngine;

public abstract class EffectTag : MonoBehaviour
{
    public bool activatedEffect = false;
    public abstract void ActivateEffect();
    public abstract void RemoveEffect();
}
