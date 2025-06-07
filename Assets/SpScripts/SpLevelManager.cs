using UnityEngine;

public class SpLevelManager : MonoBehaviour
{
    public float levelDiff;
    public PointSystem pointLevel;

    // Update is called once per frame
    void Update()
    {
        levelDiff = pointLevel.points / 100;
    }
}
