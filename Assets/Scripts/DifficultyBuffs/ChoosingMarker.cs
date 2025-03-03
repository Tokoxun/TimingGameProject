using UnityEngine;

public class ChoosingMarker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        DifficultyManager.ShortMarker = true;
    }

    // Update is called once per frame
    void OnDisable()
    {
        DifficultyManager.ShortMarker = false;
    }
}
