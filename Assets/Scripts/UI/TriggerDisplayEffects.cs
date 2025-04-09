using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffects : MonoBehaviour
{
    public int numcardListLoaded;
    public CardScripts[] cards;
    private GameObject selected;
    public List<GameObject> selectedFilter = new List<GameObject>();
    public GameObject RisksChoice;
    public void ResetList()
    {
        numcardListLoaded = 0;
        selectedFilter = new List<GameObject>();
    }

    //Section for loading tag into the cards
    public void preLoadChoice(RisksCompiler rlist)
    {
        if(rlist.Risks.Count > 0)
        {
            selected = rlist.Risks[Random.Range(0, rlist.Risks.Count)];
            for(int a = 0; a < 3; a++)
            {
                // Debug.Log(a);
                // Debug.Log(selectedFilter[a]);
                // Debug.Log(selected);
                if(selectedFilter.Count == 0)
                {
                    selectedFilter.Add(selected);
                    numcardListLoaded += 1;
                    a = -1;
                    continue;
                }
                else if(numcardListLoaded == rlist.Risks.Count)
                {
                    break;
                }
                else if(selectedFilter[a] == selected)
                {
                    selected = rlist.Risks[Random.Range(0, rlist.Risks.Count)];
                    a = -1;
                }
                else if(a >= selectedFilter.Count - 1)
                {
                     selectedFilter.Add(selected);
                     numcardListLoaded += 1;
                     // Debug.Log(numCardLoaded);
                }
             }
        }
    }

    public void loadCard()
    {
        for(int c = 0; c < selectedFilter.Count; c++)
        {
            cards[c].chosenR = selectedFilter[c];
            cards[c].RefreshCard();
        }
    }

    //Section for calculating distance between cards
    public Transform midPoint;
    public GameObject[] cardList;
    private float Distmove = 215.7f;
    public void calculatecardListPlacement()
    {
        if(numcardListLoaded > 0)
        {
            float Distgap = 432f;
            float cardListDisplacementX = midPoint.transform.localPosition.x - Distmove * (numcardListLoaded - 1);
            for(int l = 0; l < cardList.Length; l++)
            {
                if(l < numcardListLoaded)
                {
                    cardList[l].SetActive(true);
                }
                else if(l + 1 > numcardListLoaded)
                {
                    cardList[l].SetActive(false);
                }
            }
            for(int n = 0; n != numcardListLoaded; n++)
            {
                // cardList[0].transform.position = new Vector2(cardListDisplacementX, midPoint.transform.position.y);
                cardList[n].transform.localPosition = new Vector2(cardListDisplacementX, 0);
            }
            for(int m = 1; m != numcardListLoaded; m++)
            {
                cardList[m].transform.localPosition = new Vector2(cardList[m-1].transform.localPosition.x + Distgap, 0);
            }
        }
    }
}
