using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public Dropdown displayOptions;
    public Slider soundEffectSlider;
    // Update is called once per frame
    // void Update()
    // {
    //     if(displayOption.value == 0)
    //     {
    //         Screen.SetResolution(941, 701, false);
    //     }
    //     else if(displayOption.value == 1)
    //     {
    //         Screen.SetResolution(1920, 1080, true);
    //     }
    // }
    void Start()
    {
        soundEffectSlider.value = AudioManager.SEsetting;
        Screen.SetResolution(941, 701, false);
    }
    public void displayOption()
    {
        if(displayOptions.value == 1)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if(displayOptions.value == 0)
        {
            Screen.SetResolution(941, 701, false);
        }
    }
    public void Apply()
    {
        AudioManager.SEsetting = soundEffectSlider.value;
    }
    public void Revert()
    {
        soundEffectSlider.value = soundEffectSlider.maxValue;
        AudioManager.SEsetting = soundEffectSlider.maxValue;
        displayOptions.value = 0;
        displayOption();
    }
}
