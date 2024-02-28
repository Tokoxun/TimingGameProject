using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisksRandomizer : MonoBehaviour
{
    public GameObject[] risksObjects;
    public GameObject[] randomizedRisks;
    private bool startRandom = false;

    public void RandomRisksChoice()
    {
        startRandom = true;
    }

    void Update()
    {
        if(startRandom)
        {
            for(int i = 0; i < 4; i++)
            {
                randomizedRisks[i] = risksObjects[Random.Range(0, risksObjects.Length)];
            }
            if(randomizedRisks.Length == 4)
            {
                startRandom = false;
            }
        }
    }
}
