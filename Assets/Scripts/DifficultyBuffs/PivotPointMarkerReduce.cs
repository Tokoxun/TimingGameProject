using UnityEngine;

public class PivotPointMarkerReduce : EffectTag
{
    public override void ActivateEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        MarkerSpinChild3.scdPivotPoint.SetActive(false);
    }
    public override void RemoveEffect()
    {
        currentLevel = 0;
        enchanceTimer = 0;
        MarkerSpinChild3.scdPivotPoint.SetActive(true);
        MarkerSpinChild4.trdPivotPoint.SetActive(true);
    }
    public override void EnchanceEffect()
    {
        if(currentLevel == 1)
        {
            MarkerSpinChild4.trdPivotPoint.SetActive(false);
        }
    }
}
