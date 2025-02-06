using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScripts : MonoBehaviour
{
    // public Text Rnumber;
    // public Image displayR;
    // private Image ImageR;
    public RisksCompiler rlist;
    public GameObject chosenR;
    public bool Chosen = false;
    public bool choiceConfirm = false;

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
        if(!Chosen)
        {
            Chosen = true;
            Debug.Log(Chosen);
        }
        else if(Chosen)
        {
            Chosen = false;
            Debug.Log(Chosen);
        }
    }

    public void ActivateTag()
    {
        if(Chosen)
        {
            Debug.Log("Activated");
            Instantiate(chosenR, transform.position, transform.rotation);
            rlist.Risks.Remove(chosenR);
            Chosen = false;
            choiceConfirm = false;
            this.gameObject.SetActive(false);
        }
        if(!Chosen)
        {
            Chosen = false;
            choiceConfirm = false;
            this.gameObject.SetActive(false);
        }
    }
}
