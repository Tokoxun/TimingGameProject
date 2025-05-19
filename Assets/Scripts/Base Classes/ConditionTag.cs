using UnityEngine;

public class ConditionTag : MonoBehaviour
{
    public TempGroupScript tempGroupScript;
    public EffectTag linkingTag;
    void OnEnable()
    {
        linkingTag.ActivateEffect();
    }
    public void SetLink(EffectTag effectLink, TempGroupScript groupScript)
    {
        linkingTag = effectLink;
        tempGroupScript = groupScript;
    }
    public void ConditionExpire()
    {
        linkingTag.RemoveEffect();
        tempGroupScript.resetAllTemp();
        Destroy(this.gameObject);
    }
}
