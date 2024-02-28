using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceDisplay : MonoBehaviour
{
    public GameObject RisksChoice;
    public PointSystem pointsCheck;
    public RisksRandomizer chosenRisk;
    private int displayTrigger = 5;
    // Start is called before the first frame update
    void Start()
    {
        RisksChoice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pointsCheck.points >= displayTrigger)
        {
            chosenRisk.RandomRisksChoice();
            RisksChoice.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ConfirmChoice()
    {
        displayTrigger += 5;
        RisksChoice.SetActive(false);
        Time.timeScale = 1;
    }
}
