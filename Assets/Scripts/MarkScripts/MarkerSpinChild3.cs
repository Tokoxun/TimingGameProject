using UnityEngine;

public class MarkerSpinChild3 : MarkerSpinScript
{
    public static GameObject scdPivotPoint;

    void Awake()
    {
        scdPivotPoint = this.gameObject;
    }
}
