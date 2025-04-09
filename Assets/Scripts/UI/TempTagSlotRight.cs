using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TempTagSlotRight : MonoBehaviour
{
    private Image slotImage;
    private Sprite defaultSlotImage;
    public RisksCompiler conditionCompiler;
    public ConditionTag selectedCondition;
    private InfoTag infoTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slotImage = gameObject.GetComponent<Image>();
        defaultSlotImage = slotImage.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(infoTag != null)
        {
            slotImage.sprite = infoTag.baseImage.sprite;
        }
        else if(infoTag == null)
        {
            slotImage.sprite = defaultSlotImage;
        }
    }

    public void GetCondition()
    {
        int ranNum = Random.Range(0, conditionCompiler.conditionTags.Length);
        selectedCondition = conditionCompiler.conditionTags[ranNum];
        infoTag = selectedCondition.GetComponent<InfoTag>();
    }

    public void RemoveCondition()
    {
        selectedCondition = null;
        infoTag = null;
    }
}
