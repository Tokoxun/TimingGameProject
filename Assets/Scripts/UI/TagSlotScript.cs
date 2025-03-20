using UnityEngine;
using UnityEngine.UI;

public class TagSlotScript : MonoBehaviour
{
    private TagInventory tagStash;
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
        if(tags != null)
        {
            InfoTag tagInfo = tags.GetComponent<InfoTag>();
            tagImageToChange = tagInfo.tagImage;
            tagNumber.text = tagInfo.rNumber.ToString();
            currentTagImage.sprite = tagImageToChange.sprite;
        }
        else if(tags == null)
        {
            currentTagImage.sprite = emptySlotImage;
            tagImageToChange = null;
            tagNumber.text = null;
        }
    }

    public void RemoveTag()
    {
        EffectTag tagEffect = tags.GetComponent<EffectTag>();
        tagEffect.RemoveEffect();
        tagStash.selectedTags.Remove(tags);
        tags = null;
        currentTagImage.sprite = emptySlotImage;
        tagImageToChange = null;
        tagNumber.text = null;

    }
}
