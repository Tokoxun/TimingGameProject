using UnityEngine;

public class PauseDisable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        DifficultyManager.disablePause = true;
    }

    void OnDisable()
    {
        DifficultyManager.disablePause = false;
    }
}
