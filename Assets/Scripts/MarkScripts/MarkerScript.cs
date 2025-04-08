using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    public SpriteRenderer fstHitMark;
    public bool onHitted;
    public Collider2D markCol;
    public GameObject scdHitMark;
    public GameObject trdHitMark;
    public PointSystem addPoints;
    void Start()
    {
        onHitted = false;
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
            onHitted = true;
            fstHitMark.enabled = false;
            markCol.enabled = false;
            addPoints.AddPoint();
        }
    }

    public void Respawn()
    {
        onHitted = false;
        fstHitMark.enabled = true;
        markCol.enabled = true;
        scdHitMark.SetActive(DifficultyManager.secondHit);
        trdHitMark.SetActive(DifficultyManager.thirdHit);
    }
}
