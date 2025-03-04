using UnityEngine;

public class DisappearingTrigger : MonoBehaviour
{
    void OnEnable()
    {
        DifficultyManager.mrkDisap = true;
    }

    void OnDisable()
    {
        DifficultyManager.mrkDisap = false;
    }
}
