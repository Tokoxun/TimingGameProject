using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeHitMarker : MonoBehaviour
{
    public Text RnumImg;
    public Image RImg;
    public Sprite TargetImg;
    private int Rnum = 2;
    public Image DispR;
    private bool toggled = false;

    void Start()
    {
        RnumImg.text = Rnum.ToString();
        RImg.sprite = TargetImg;
    }
    public void ThreeHitSelect()
    {
        if(!toggled)
        {
            DifficultyManager.secondHit = true;
            DifficultyManager.thirdHit = true;
            DispR.sprite = TargetImg;
            toggled = true;
            return;
        }
        if(toggled)
        {
            DifficultyManager.secondHit = false;
            DifficultyManager.thirdHit = false;
            DispR.sprite = null;
            toggled = false;
            return;
        }
    }
}
