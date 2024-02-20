using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    public GameObject scdHitMark;
    public GameObject trdHitMark;
    void Start()
    {
        scdHitMark.SetActive(DifficultyManager.secondHit);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("point"))
        {
            gameObject.SetActive(false);
        }
    }
}
