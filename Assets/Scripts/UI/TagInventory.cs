using System.Collections.Generic;
using UnityEngine;

public class TagInventory : MonoBehaviour
{
    public List<GameObject> selectedTags = new List<GameObject>();
    private int currentTag;
    public TagSlotScript[] tagSlot;

    void Start()
    {
        currentTag = 0;
    }
    void Update()
    {
        if(selectedTags.Count != currentTag && tagSlot != null)
        {
            for(int t = 0; t < selectedTags.Count; t++)
            {
                InfoTag tagInfo = selectedTags[t].GetComponent<InfoTag>();
                if(tagInfo != null)
                {
                    tagSlot[t].tagImage = tagInfo.tagImage;
                    tagSlot[t].tagNumber.text = tagInfo.rNumber.ToString();
                    currentTag = selectedTags.Count;
                }
            }
        }
    }
}
