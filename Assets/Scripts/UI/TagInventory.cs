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
            Debug.Log("Changed");
            for(int t = 0; t < tagSlot.Length; t++)
            {
                if(t < selectedTags.Count)
                {
                    tagSlot[t].tags = selectedTags[t];
                }
                else
                {
                    tagSlot[t].tags = null;
                }
            }
            currentTag = selectedTags.Count;
        }
    }
}
