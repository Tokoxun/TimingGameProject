using UnityEngine;
using UnityEngine.UI;

public class TempTagSlot : MonoBehaviour
{
    private Image slotImage;
    private Sprite defaultSlotImage;
    public RisksCompiler tempCompiler;
    public TempGroupScript linkTemp;
    public GameObject selectedTag;
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
        if(selectedTag != null)
        {
            linkTemp.resetAllTemp += RemoveTag;
            slotImage.sprite = infoTag.baseImage.sprite;
        }
        else if(selectedTag == null)
        {
            slotImage.sprite = defaultSlotImage;
        }
    }

    public void GetTags()
    {
        int ranNum = Random.Range(0, tempCompiler.tempRisks.Count);
        selectedTag = tempCompiler.tempRisks[ranNum];
        infoTag = selectedTag.GetComponent<InfoTag>();
    }

    public void RemoveTag()
    {
        selectedTag = null;
        infoTag = null;
    }
}
