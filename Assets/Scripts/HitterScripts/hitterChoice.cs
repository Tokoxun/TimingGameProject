using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitterChoice : MonoBehaviour
{
    public InputAction currentInput;
    public GameObject enablShortHitter;
    public GameObject enablLongHitter;
    public Collider2D hitPointLong;
    public Collider2D hitPointShort;
    // Start is called before the first frame update
    void Start()
    {
        enablShortHitter.SetActive(false);
        enablLongHitter.SetActive(true);
    }

    public void OnButtonHit()
    {
        if(enablLongHitter.activeSelf)
        {
            hitPointLong.enabled = true;
        }
        else if(enablShortHitter.activeSelf)
        {
            hitPointShort.enabled = true;
        }
    }

    void Update()
    {
        enablLongHitter.SetActive(DifficultyManager.LongHitter);
        enablShortHitter.SetActive(DifficultyManager.ShortHitter);
    }
}
