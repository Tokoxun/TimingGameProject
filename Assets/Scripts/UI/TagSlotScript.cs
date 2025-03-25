using UnityEngine;
using UnityEngine.UI;

public class TagSlotScript : MonoBehaviour
{
    private TagInventory tagStash;
    private EffectTag tagEnchance;
    public GameObject tags;
    private Image currentTagImage;
    private Image tagImageToChange;
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
            tagImageToChange = null;
            tagNumber.text = null;
        }
    }

    public void RefreshSlotImage()
    {
        tagEnchance = tags.GetComponent<EffectTag>();
        InfoTag tagInfo = tags.GetComponent<InfoTag>();
        tagImageToChange = tagInfo.tagImage;
        tagNumber.text = tagInfo.rNumber.ToString();
        currentTagImage.sprite = tagImageToChange.sprite;
    }

    public void RemoveTag()
    {
        EffectTag removeTagEffect = tags.GetComponent<EffectTag>();
        removeTagEffect.RemoveEffect();
        tagStash.selectedTags.Remove(tags);
        tags = null;
        currentTagImage.sprite = emptySlotImage;
        tagImageToChange = null;
        tagNumber.text = null;

    }
}
