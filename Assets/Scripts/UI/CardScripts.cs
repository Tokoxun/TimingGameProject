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
    private EffectChoice effectChoice;
    private EffectTag activateCurrentEffect;
    public Animator appearAnim;
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
        activateCurrentEffect = chosenR.GetComponent<EffectTag>();
        InfoTag rInfo = chosenR.GetComponent<InfoTag>();
        displayR.sprite = rInfo.baseImage.sprite;
        displayRnumber.text = rInfo.rNumber.ToString();
    }

    public void SelectedCard()
    {
        if (!Chosen)
        {
            Chosen = true;
            EffectChoice.chosenTag += ActivateTag;
            effectChoice.selectedChoice += 1;
            selectedAnimation.SetBool("selected", true);
        }
        else if (Chosen)
        {
            Chosen = false;
            EffectChoice.chosenTag -= ActivateTag;
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
