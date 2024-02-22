using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitterChoice : MonoBehaviour
{
    public GameObject enablShortHitter;
    public GameObject enablLongHitter;
    // Start is called before the first frame update
    void Start()
    {
        enablShortHitter.SetActive(DifficultyManager.ShortHitter);
        enablLongHitter.SetActive(DifficultyManager.LongHitter);
    }
}
