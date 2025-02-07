using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScripts : MonoBehaviour
{
    public Text displayRnumber;
    public Image displayR;
    // private Image ImageR;
    public RisksCompiler rlist;
    public GameObject chosenR;
    public bool Chosen = false;
    public bool choiceConfirm = false;

    // Update is called once per frame
    void Update()
    {
        if(chosenR != null)
        {
            InfoTag rInfo = chosenR.GetComponent<InfoTag>();
            if(rInfo != null)
            {
                displayR.sprite = rInfo.tagImage.sprite;
                displayRnumber.text = rInfo.rNumber.ToString();
            }
        }
    }

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
            displayR.sprite = null;
            displayRnumber.text = null;
            this.gameObject.SetActive(false);
        }
        if(!Chosen)
        {
            Chosen = false;
            choiceConfirm = false;
            displayR.sprite = null;
            displayRnumber.text = null;
            this.gameObject.SetActive(false);
        }
    }
}
