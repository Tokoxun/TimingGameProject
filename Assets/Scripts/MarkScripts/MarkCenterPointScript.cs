using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkCenterPointScript : MonoBehaviour
{
    public GameObject scdPivotPoint;
    public GameObject trdPivotPoint;
    // Start is called before the first frame update
    void Start()
    {
        scdPivotPoint.SetActive(DifficultyManager.secondPivotPoint);
        trdPivotPoint.SetActive(DifficultyManager.thirdPivotPoint);   
    }
}
