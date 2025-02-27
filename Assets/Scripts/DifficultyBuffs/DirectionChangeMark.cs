using UnityEngine;

public class DirectionChangeMark : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        DifficultyManager.rotateMarker = true;
    }

    private void OnDisable()
    {
        DifficultyManager.rotateMarker = false;
    }
}
