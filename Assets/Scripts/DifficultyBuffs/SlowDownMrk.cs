using UnityEngine;

public class SlowDownMrk : MonoBehaviour
{
    private float SpdDownMrk = 5f;

    void OnEnable()
    {
        DifficultyManager.decreaseMrkSpd += SpdDownMrk;
    }

    void OnDisable()
    {
        DifficultyManager.decreaseMrkSpd -= SpdDownMrk;
    }
}
