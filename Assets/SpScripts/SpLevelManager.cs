using UnityEngine;

public class SpLevelManager : MonoBehaviour
{
    public float levelDiff;
    public PointSystem pointLevel;
    public bool startSwitch;

    void Start()
    {
        startSwitch = false;
    }
    // Update is called once per frame
    void Update()
    {
        levelDiff = (float)pointLevel.points / 100;
        if (pointLevel.points >= 20)
        {
            startSwitch = true;
        }
    }
}
