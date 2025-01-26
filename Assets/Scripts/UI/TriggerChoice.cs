using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerChoice : MonoBehaviour
{
    public GameObject[] card;
    public GameObject selected;
    public GameObject[] selectedFilter;
    public RisksCompiler rlist;
    public PointSystem pointsCheck;
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
            preLoadChoice();
            signal = false;
            displayChoice += 5;
        }
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
            selected = rlist.Risks[Random.Range(0, rlist.Risks.Length)];
            for(int a = 0; a < selectedFilter.Length; a++)
            {
                Debug.Log(a);
                Debug.Log(selectedFilter[a]);
                Debug.Log(selected);
                if(selectedFilter[a] == selected)
                {
                    i = 0;
                    a = selectedFilter.Length;
                }
                if(a >= selectedFilter.Length - 1)
                {
                    selectedFilter[i] = selected;
                }
            }
        }
    }
}
