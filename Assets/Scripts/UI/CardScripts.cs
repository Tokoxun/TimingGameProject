using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardScripts : MonoBehaviour
{
    public TextMeshProUGUI tagNameDisplay;
    public Text displayRnumber;
    public Image displayR;
    public DetailsDisplayer displayDetails;
    // private Image ImageR;
    public RisksCompiler rlist;
    public TagInventory playerInventory;
    public GameObject chosenR;
    private EffectChoice effectChoice;
    private EffectTag activateCurrentEffect;
    public Animator selectedAnimation;
    public bool Chosen = false;

    // void Update()
    // {
    //     if(chosenR != null)
    //     {
    //         tagEffect = chosenR.GetComponent<EffectTag>();
    //         InfoTag rInfo = chosenR.GetComponent<InfoTag>();
    //         if(rInfo != null)
    //         {
    //             displayR.sprite = rInfo.tagImage.sprite;
    //             displayRnumber.text = rInfo.rNumber.ToString();
    //         }
    //     }
    // }
    void Start()
    {
        effectChoice = gameObject.GetComponentInParent<EffectChoice>();
    }
    public void RefreshCard()
    {
        Chosen = false;
        selectedAnimation.SetBool("selected", false);
        activateCurrentEffect = chosenR.GetComponent<EffectTag>();
        InfoTag rInfo = chosenR.GetComponent<InfoTag>();
        tagNameDisplay.text = rInfo.tagName;
        displayR.sprite = rInfo.baseImage.sprite;
        displayRnumber.text = rInfo.details[rInfo.detailLevel].rNumber.ToString();
        displayDetails.UpdateDetail(rInfo.details[rInfo.detailLevel].Description, rInfo.details[rInfo.detailLevel].detailsName);
    }

    public void SelectedCard()
    {
        if (!Chosen)
        {
            Chosen = true;
            effectChoice.chosenTag += ActivateTag;
            effectChoice.selectedChoice += 1;
            selectedAnimation.SetBool("selected", true);
        }
        else if (Chosen)
        {
            Chosen = false;
            effectChoice.chosenTag -= ActivateTag;
            effectChoice.selectedChoice -= 1;
            selectedAnimation.SetBool("selected", false);
        }
    }

    public void ActivateTag()
    {
        Chosen = false;
        // Instantiate(chosenR, transform.position, transform.rotation);
        activateCurrentEffect.ActivateEffect();
        playerInventory.selectedTags.Add(chosenR);
        rlist.Risks.Remove(chosenR);
    }
}
