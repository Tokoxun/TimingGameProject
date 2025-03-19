using UnityEngine;
using UnityEngine.UI;

public class TagSlotScript : MonoBehaviour
{
    private Image slotImage;
    public Image tagImage;
    public Image emptySlotImage;
    public Text tagNumber;

    void Start()
    {
        slotImage = this.gameObject.GetComponent<Image>();
    }
    void Update()
    {
        if(tagImage != null)
        {
            slotImage.sprite = tagImage.sprite;
        }
    }
}
