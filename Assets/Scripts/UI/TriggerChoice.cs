using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerChoice : MonoBehaviour
{
    public CardScripts card1;
    public CardScripts card2;
    public CardScripts card3;
    public CardScripts card4;
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
            signal = false;
            displayChoice += 5;
        }
    }

    public void ConfirmChoice()
    {
        RisksChoice.SetActive(false);
        Time.timeScale = 1;
    }
}
