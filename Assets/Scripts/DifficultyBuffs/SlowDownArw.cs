using UnityEngine;

public class SlowDownArw : MonoBehaviour
{
    private float SpdDwn = 5f;

    void OnEnable()
    {
        DifficultyManager.decreaseArwSpd += SpdDwn;
    }

    void OnDisable()
    {
        DifficultyManager.decreaseArwSpd -= SpdDwn;
    }
}
