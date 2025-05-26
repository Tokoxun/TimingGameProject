using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardScriptsStarter : MonoBehaviour
{
    public TextMeshProUGUI tagNameDisplay;
    public Text DisplayRNum;
    public Image DisplayStartR;
    public TagInventory playerInventory;
    public GameObject starterTag;
    public EffectTag tagEffect;
    public bool Chosen;
    public Animator selectedAnimation; 
    public EffectChoiceStarter choosing;

    void Start()
    {
        InfoTag infoTag = starterTag.GetComponent<InfoTag>();
        DisplayRNum.text = infoTag.details[infoTag.detailLevel].rNumber.ToString();
        DisplayStartR.sprite = infoTag.baseImage.sprite;
        tagNameDisplay.text = infoTag.tagName;
    }
    public void SelectedCard()
    {
        if (!Chosen)
        {
            Chosen = true;
            choosing.startEffect = ActivateStarterTag;
            choosing.cardStarter.Add(this.gameObject.GetComponent<CardScriptsStarter>());
            selectedAnimation.SetBool("selected", true);
        }
        else if (Chosen)
        {
            Chosen = false;
            choosing.startEffect = null;
            choosing.cardStarter.Remove(this.gameObject.GetComponent<CardScriptsStarter>());
            selectedAnimation.SetBool("selected", false);
        }
    }

    public void ActivateStarterTag()
    {
        playerInventory.selectedTags.Add(starterTag);
        tagEffect.ActivateEffect();
    }
}
