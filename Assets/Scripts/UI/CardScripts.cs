using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScripts : MonoBehaviour
{
    // public Text Rnumber;
    // public Image displayR;
    // private Image ImageR;
    public GameObject chosenR;
    public bool selected = false;

    // Update is called once per frame
    void Update()
    {
        // if(chosenR != null)
        // {
        //     displayR.sprite = ImageR.sprite;
        // }
    }

    // public void LoadingCard()
    // {
    //     if(RisksList.Risks.Length >= 1)
    //     {
    //         displayR.enabled = true;
    //         chosenR = RisksList.Risks[Random.Range(0, RisksList.Risks.Length)];
    //         ImageR = chosenR.GetComponent<Image>();
    //     }
    //     if(RisksList.Risks.Length < 1)
    //     {
    //         displayR.enabled = false;
    //     }
    // }

    public void SelectedCard()
    {
        if(!selected)
        {
            selected = true;
            Instantiate(chosenR, transform.position, transform.rotation);
            Debug.Log(selected);
        }
        else if(selected)
        {
            selected = false;
            Debug.Log(selected);
        }
    }
}
