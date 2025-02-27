using UnityEngine;

public class DirectionChangeHitter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        DifficultyManager.rotateHitter = true;
    }

    private void OnDisable()
    {
        DifficultyManager.rotateHitter = false;
    }
}
