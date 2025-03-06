using UnityEngine;

public class VariableHitTrigger : MonoBehaviour
{
    void OnEnable()
    {
        DifficultyManager.displayVariableNum = true;
    }

    void OnDisable()
    {
        DifficultyManager.displayVariableNum = false;
    }
}
