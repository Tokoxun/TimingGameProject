using UnityEngine;

public class PivotPointMarkerReduce : EffectTag
{
    public override void ActivateEffect()
    {
        MarkerSpinChild3.scdPivotPoint.SetActive(false);
    }
    public override void RemoveEffect()
    {
        MarkerSpinChild3.scdPivotPoint.SetActive(true);
    }
}
