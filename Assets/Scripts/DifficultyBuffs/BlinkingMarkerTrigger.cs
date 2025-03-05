using UnityEngine;

public class BlinkingMarkerTrigger : MonoBehaviour
{
    void OnEnable()
    {
        DifficultyManager.mrkBlink = true;
    }

    void OnDisable()
    {
        DifficultyManager.mrkBlink = false;
    }
}
