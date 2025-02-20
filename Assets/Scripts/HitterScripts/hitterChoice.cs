using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitterChoice : MonoBehaviour
{
    private bool currentHitter = false;
    private bool changeHitter = false;
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
        changeHitter = DifficultyManager.ShortHitter;
        if(currentHitter == changeHitter)
        {
            return;
        }
        else if(currentHitter != changeHitter)
        {
            enablLongHitter.SetActive(false);
            enablShortHitter.SetActive(true);
            currentHitter = changeHitter;
        }
    }
}
