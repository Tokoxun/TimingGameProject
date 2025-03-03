using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    public SpriteRenderer fstHitMark;
    public Collider2D markCol;
    public GameObject scdHitMark;
    public GameObject trdHitMark;
    void Start()
    {
        scdHitMark.SetActive(DifficultyManager.secondHit);
        trdHitMark.SetActive(DifficultyManager.thirdHit);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("point"))
        {
            if(trdHitMark.activeSelf)
            {
                trdHitMark.SetActive(false);
                return;
            }
            if(scdHitMark.activeSelf)
            {
                scdHitMark.SetActive(false);
                return;
            }
            fstHitMark.enabled = false;
            markCol.enabled = false;
        }
    }

    public void Respawn()
    {
        fstHitMark.enabled = true;
        markCol.enabled = true;
        scdHitMark.SetActive(DifficultyManager.secondHit);
        trdHitMark.SetActive(DifficultyManager.thirdHit);
    }
}
