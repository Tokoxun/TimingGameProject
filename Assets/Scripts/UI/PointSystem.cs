using TMPro;
using UnityEngine;
public class PointSystem : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI PointsDisplay;

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
