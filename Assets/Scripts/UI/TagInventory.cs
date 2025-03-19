using System.Collections.Generic;
using UnityEngine;

public class TagInventory : MonoBehaviour
{
    public List<GameObject> selectedTags = new List<GameObject>();
    public TagSlotScript[] tagSlot;

    void Update()
    {
        if(selectedTags.Count > 0 && tagSlot != null)
        {
            for(int t = 0; t < tagSlot.Length; t++)
            {
                InfoTag tagInfo = selectedTags[t].GetComponent<InfoTag>();
                if(tagInfo != null)
                {
                    tagSlot[t].tagImage = tagInfo.tagImage;
                    tagSlot[t].tagNumber.text = tagInfo.rNumber.ToString();
                }
            }
        }
    }
}
