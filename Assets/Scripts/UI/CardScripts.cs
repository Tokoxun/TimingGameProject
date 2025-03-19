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
    public TagInventory playerInventory;
    public GameObject chosenR;
    public bool Chosen = false;

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
            EffectChoice.chosenTag += ActivateTag;
        }
        else if(Chosen)
        {
            Chosen = false;
            EffectChoice.chosenTag -= ActivateTag;
        }
    }

    public void ActivateTag()
    {
        Chosen = false;
        Instantiate(chosenR, transform.position, transform.rotation);
        playerInventory.selectedTags.Add(chosenR);
        rlist.Risks.Remove(chosenR);
    }
}
