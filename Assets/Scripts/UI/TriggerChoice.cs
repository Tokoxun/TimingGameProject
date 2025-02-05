using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerChoice : MonoBehaviour
{
    public GameObject[] card;
    public Transform midPoint;
    private float Distmove = 215.7f;
    public PointSystem pointsCheck;
    public TriggerEffects loadEffect;
    public GameObject RisksChoice;
    public int displayChoice = 5;
    public bool signal = false;
    // Start is called before the first frame update
    void Start()
    {
        RisksChoice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pointsCheck.points >= displayChoice)
        {
            signal = true;
            RisksChoice.SetActive(true);
            Time.timeScale = 0;
        }

        if(signal)
        {
            // card1.LoadingCard();
            // card2.LoadingCard();
            // card3.LoadingCard();
            // card4.LoadingCard();
            loadEffect.preLoadChoice();
            calculateCardPlacement();
            signal = false;
            displayChoice += 5;
        }
    }



    public void calculateCardPlacement()
    {
        if(loadEffect.numCardLoaded > 0)
        {
            float Distgap = 432f;
            float CardDisplacementX = midPoint.transform.localPosition.x - Distmove * (loadEffect.numCardLoaded - 1);
            for(int n = 0; n != loadEffect.numCardLoaded; n++)
            {
                // card[0].transform.position = new Vector2(CardDisplacementX, midPoint.transform.position.y);
                card[n].SetActive(true);
                card[n].transform.localPosition = new Vector2(CardDisplacementX, 0);
            }
            for(int m = 1; m != loadEffect.numCardLoaded; m++)
            {
                card[m].transform.localPosition = new Vector2(card[m-1].transform.localPosition.x + Distgap, 0);
            }
        }
    }
}
