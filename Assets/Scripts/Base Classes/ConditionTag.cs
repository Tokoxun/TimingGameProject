using UnityEngine;

public class ConditionTag : MonoBehaviour
{
    public TempGroupScript tempGroupScript;
    public EffectTag linkingTag;
    public void SetLink(EffectTag effectLink, TempGroupScript groupScript)
    {
        linkingTag = effectLink;
        tempGroupScript = groupScript;
    }
    public void ConditionExpire()
    {
        linkingTag.RemoveEffect();
        Destroy(this.gameObject);
    }
}
