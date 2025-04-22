using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public GameObject optionMenu;
    public Dropdown displayOptions;
    private int currentDisplay;
    public Slider soundEffectSlider;
    public Animator changesApplied;
    public GameObject confirmWarning;
    private bool applyChange;
    [SerializeField] private float appearTime = 2f;
    private float appearTimer;
    // Update is called once per frame
    void Update()
    {
        if(soundEffectSlider.value != AudioManager.SEsetting)
        {
            applyChange = false;
        }
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
        applyChange = true;
        confirmWarning.SetActive(false);
        soundEffectSlider.value = AudioManager.SEsetting;
        displayOptions.value = currentDisplay;
    }
    public void displayOption()
    {
        if(displayOptions.value == 1)
        {
            Screen.SetResolution(1920, 1080, true);
            currentDisplay = 1;
        }
        if(displayOptions.value == 0)
        {
            Screen.SetResolution(941, 701, false);
            currentDisplay = 0;
        }
    }
    public void Apply()
    {
        confirmWarning.SetActive(false);
        AudioManager.SEsetting = soundEffectSlider.value;
        changesApplied.SetBool("applied", true);
        applyChange = true;
    }
    public void Revert()
    {
        confirmWarning.SetActive(false);
        applyChange = true;
        soundEffectSlider.value = soundEffectSlider.maxValue;
        AudioManager.SEsetting = soundEffectSlider.maxValue;
        displayOptions.value = 0;
        displayOption();
    }
    public void CloseOption()
    {
        if(!applyChange)
        {
            confirmWarning.SetActive(true);
        }
        else if(applyChange)
        {
            optionMenu.SetActive(false);
        }
    }
}
