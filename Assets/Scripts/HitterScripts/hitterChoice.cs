using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitterChoice : MonoBehaviour
{
    public GameObject enablShortHitter;
    public GameObject enablLongHitter;
    public bool changeHit = false;
    public bool actvLong = false;
    public bool actvShort = false;
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
        if(actvLong == true)
        {
            hitPointLong.enabled = true;
        }
        else if(actvShort == true)
        {
            hitPointShort.enabled = true;
        }
    }

    void Update()
    {
        if(changeHit == false)
        {
            actvLong = true;
            actvShort = false;
            enablLongHitter.SetActive(true);
            enablShortHitter.SetActive(false);
        }
        else if(changeHit == true)
        {
            actvLong = false;
            actvShort = true;
            enablLongHitter.SetActive(false);
            enablShortHitter.SetActive(true);
        }
    }
}
