using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsColorSwitch : MonoBehaviour
{
    public int changeNum = 1;
    public Image imageToChange;
    public Sprite greenSprite;
    public Sprite redSprite;

    // Call this method to change the image
    public void ChangeSourceImage()
    {
        if (changeNum > 1)
        {
            imageToChange.sprite = redSprite;
        }
        if(changeNum == 1)
        {
            imageToChange.sprite = greenSprite;
        }
    }
}
