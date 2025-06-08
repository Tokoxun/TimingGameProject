using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public GameObject optionMenu;
    public Dropdown displayOptions;
    public static int currentDisplay;
    public Slider soundEffectSlider;
    public Animator changesApplied;
    public GameObject confirmWarning;
    [SerializeField] private float appearTime = 2f;
    private float appearTimer;
    // Update is called once per frame
    void Update()
    {
        if(changesApplied.GetBool("applied") == true)
        {
            appearTimer += Time.deltaTime;
            if(appearTimer >= appearTime)
            {
                changesApplied.SetBool("applied", false);
                appearTimer = 0;
            }
        }
    }
    void Start()
    {
        confirmWarning.SetActive(false);
        soundEffectSlider.value = PlayerPrefs.GetFloat("volume", soundEffectSlider.maxValue);
        displayOptions.value = PlayerPrefs.GetInt("screenDisplay", 0);
    }
    public void displayOption()
    {
        if (displayOptions.value == 1)
        {
            Screen.SetResolution(1920, 1080, true);
            currentDisplay = 1;
            PlayerPrefs.SetInt("screenDisplay", currentDisplay);
        }
        if (displayOptions.value == 0)
        {
            Screen.SetResolution(941, 701, false);
            currentDisplay = 0;
            PlayerPrefs.SetInt("screenDisplay", currentDisplay);
        }
    }
    public void volumeValueChanged()
    {
        PlayerPrefs.SetFloat("volume", soundEffectSlider.value);
        AudioManager.SEsetting = soundEffectSlider.value;
    }
    // public void Apply()
    // {
    //     confirmWarning.SetActive(false);
    //     AudioManager.SEsetting = soundEffectSlider.value;
    //     changesApplied.SetBool("applied", true);
    // }
    public void Revert()
    {
        // confirmWarning.SetActive(false);
        soundEffectSlider.value = soundEffectSlider.maxValue;
        AudioManager.SEsetting = soundEffectSlider.maxValue;
        displayOptions.value = 0;
        displayOption();
    }
    // public void CancelSave()
    // {
    //     soundEffectSlider.value = AudioManager.SEsetting;
    //     confirmWarning.SetActive(false);
    // }
    public void CloseOption()
    {
        // if(soundEffectSlider.value != AudioManager.SEsetting)
        // {
        //     confirmWarning.SetActive(true);
        // }
        // else if(soundEffectSlider.value == AudioManager.SEsetting)
        // {
        //     optionMenu.SetActive(false);
        // }
        optionMenu.SetActive(false);
    }
}
