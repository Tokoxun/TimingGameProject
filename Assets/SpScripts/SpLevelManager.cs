using UnityEngine;

public class SpLevelManager : MonoBehaviour
{
    public SpSpinScript spSpinScript;
    public SpMarkerScript spMarkerScript;
    public float levelDiff;
    public PointSystem pointLevel;
    public bool hitterSwitch;
    public bool markSwitch;
    public bool startSwitch;

    void Start()
    {
        startSwitch = false;
    }
    // Update is called once per frame
    void Update()
    {
        levelDiff = (float)pointLevel.points / 100;
        switch (pointLevel.points)
        {
            case 20:
                markSwitch = true;
                break;
            case 30:
                hitterSwitch = true;
                break;
            case 50:
                spSpinScript.signalTime = 0.5f;
                break;
            case 100:
                spSpinScript.signalTime = 0.2f;
                break;
        }
    }
}
