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
    public AudioManager audioManager;
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
                audioManager.Play("MarkHitted");
                trdHitMark.SetActive(false);
                return;
            }
            if(scdHitMark.activeSelf)
            {
                audioManager.Play("MarkHitted");
                scdHitMark.SetActive(false);
                return;
            }
            audioManager.Play("MarkHitted");
            onHitted = true;
            fstHitMark.enabled = false;
            markCol.enabled = false;
            addPoints.AddPoint(1);
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
