using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerChoice : MonoBehaviour
{
    public GameObject[] cardList;
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
            loadEffect.preLoadChoice();
            calculatecardListPlacement();
            loadEffect.loadCard();
            signal = false;
            displayChoice += 5;
        }
    }



    public void calculatecardListPlacement()
    {
        if(loadEffect.numcardListLoaded > 0)
        {
            float Distgap = 432f;
            float cardListDisplacementX = midPoint.transform.localPosition.x - Distmove * (loadEffect.numcardListLoaded - 1);
            for(int n = 0; n != loadEffect.numcardListLoaded; n++)
            {
                // cardList[0].transform.position = new Vector2(cardListDisplacementX, midPoint.transform.position.y);
                cardList[n].SetActive(true);
                cardList[n].transform.localPosition = new Vector2(cardListDisplacementX, 0);
            }
            for(int m = 1; m != loadEffect.numcardListLoaded; m++)
            {
                cardList[m].transform.localPosition = new Vector2(cardList[m-1].transform.localPosition.x + Distgap, 0);
            }
        }
    }
}
