using UnityEngine;
using UnityEngine.UI;

public class TagSlotScript : MonoBehaviour
{
    private TagInventory tagStash;
    private EffectTag tagEnchance;
    private InfoTag tagInfo;
    public GameObject tags;
    private Image currentTagImage;
    private Sprite emptySlotImage;
    public Text tagNumber;

    void Start()
    {
        currentTagImage = this.gameObject.GetComponent<Image>();
        emptySlotImage = currentTagImage.sprite;
        tagStash = GetComponentInParent<TagInventory>();
    }
    void Update()
    {
        if(tagInfo != null)
        {
            switch(tagEnchance.currentLevel)
            {
                case 0:
                    currentTagImage.sprite = tagInfo.baseImage.sprite;
                    tagNumber.text = tagInfo.rNumber.ToString();
                    break;
                case 1:
                    currentTagImage.sprite = tagInfo.Level_II;
                    tagNumber.text = tagInfo.rNumber.ToString();
                    break;
                case 2:
                    currentTagImage.sprite = tagInfo.Level_III;
                    tagNumber.text = tagInfo.rNumber.ToString();
                    break;
            }
        }
        if(tagEnchance != null)
        {
            // Debug.Log(tagEnchance.maxLevel);
            // Debug.Log(tagEnchance.phase);
            if(tagEnchance.currentLevel < tagEnchance.maxLevel && tagEnchance.phase)
            {
                tagEnchance.enchanceTimer += Time.deltaTime;
                if(tagEnchance.enchanceTimer >= tagEnchance.enchanceTime)
                {
                    tagEnchance.currentLevel += 1;
                    tagEnchance.EnchanceEffect();
                    tagEnchance.enchanceTimer = 0;
                }
            }
        }
        if(tags == null)
        {
            currentTagImage.sprite = emptySlotImage;
            tagNumber.text = null;
            tagInfo = null;
            tagEnchance = null;
        }
    }

    public void RefreshSlotImage()
    {
        tagEnchance = tags.GetComponent<EffectTag>();
        tagInfo = tags.GetComponent<InfoTag>();
    }

    public void RemoveTag()
    {
        EffectTag removeTagEffect = tags.GetComponent<EffectTag>();
        removeTagEffect.RemoveEffect();
        tagStash.selectedTags.Remove(tags);
        tagInfo = null;
        tagEnchance = null;
        tags = null;
        currentTagImage.sprite = emptySlotImage;
        tagNumber.text = null;

    }
}
