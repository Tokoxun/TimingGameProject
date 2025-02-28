using UnityEngine;

public class PivotPointMarkerReduce : MonoBehaviour
{
    void OnEnable()
    {
        MarkerSpinChild3.scdPivotPoint.SetActive(false);
    }

    void OnDisable()
    {
        MarkerSpinChild3.scdPivotPoint.SetActive(true);
    }
}
