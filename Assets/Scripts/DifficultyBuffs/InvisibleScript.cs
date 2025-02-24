using UnityEngine;

public class InvisibleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        DifficultyManager.displayHitterSprite = true;
    }

    void OnDisable()
    {
        DifficultyManager.displayHitterSprite = false;
    }
}
