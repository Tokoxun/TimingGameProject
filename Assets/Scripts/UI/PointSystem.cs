using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public Text PointsDisplay;

    // Update is called once per frame
    void Update()
    {
        PointsDisplay.text = points.ToString();
    }

    public void AddPoint()
    {
        points += 1;
    }
}
