using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffects : MonoBehaviour
{
    public int numcardListLoaded;
    public GameObject RisksChoice;
    public CardScripts[] cards;
    private GameObject selected;
    public List<GameObject> selectedFilter = new List<GameObject>();
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
        if(rlist.Risks.Count > 0)
        {
            selected = rlist.Risks[Random.Range(0, rlist.Risks.Count)];
            for(int a = 0; a != 4; a++)
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
        }
    }
}
