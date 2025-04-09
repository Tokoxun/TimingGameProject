using UnityEngine;

public abstract class EffectTag : MonoBehaviour
{
    public bool phase = false;
    public int currentLevel;
    public int maxLevel;
    public float enchanceTimer;
    public float enchanceTime;
    public abstract void ActivateEffect();
    public abstract void RemoveEffect();
    public abstract void EnchanceEffect();
}
