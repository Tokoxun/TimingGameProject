using UnityEngine;

public class RespawnMarkDown : MonoBehaviour
{
    private float decreaseMrkRespawn = 1f;

    void OnEnable()
    {
        DifficultyManager.addMrkRespawn += decreaseMrkRespawn;
    }

    void OnDisable()
    {
        DifficultyManager.addMrkRespawn -= decreaseMrkRespawn;
    }
}
