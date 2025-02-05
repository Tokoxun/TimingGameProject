using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffects : MonoBehaviour
{
    public int numcardListLoaded;
    public GameObject RisksChoice;
    public CardScripts[] cards;
    private GameObject selected;
    public GameObject[] selectedFilter;
    public RisksCompiler rlist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConfirmChoice()
    {
        RisksChoice.SetActive(false);
        Time.timeScale = 1;
    }

    public void preLoadChoice()
    {
        for(int i = 0; i < selectedFilter.Length; i++)
        {
            if(rlist.Risks.Length > 0)
            {
                selected = rlist.Risks[Random.Range(0, rlist.Risks.Length)];
                for(int a = 0; a < selectedFilter.Length; a++)
                {
                    // Debug.Log(a);
                    // Debug.Log(selectedFilter[a]);
                    // Debug.Log(selected);
                    if(numcardListLoaded == rlist.Risks.Length)
                    {
                        break;
                    }
                    if(selectedFilter[a] == selected)
                    {
                        selected = rlist.Risks[Random.Range(0, rlist.Risks.Length)];
                        a = -1;
                    }
                    if(a >= selectedFilter.Length - 1)
                    {
                        selectedFilter[i] = selected;
                        numcardListLoaded += 1;
                        // Debug.Log(numCardLoaded);
                    }
                }
            }
        }
    }

    public void loadCard()
    {
        for(int c = 0; c < selectedFilter.Length; c++)
        {
            cards[c].chosenR = selectedFilter[c];
        }
    }
}
