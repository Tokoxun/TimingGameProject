using UnityEngine;
using UnityEngine.UI;

public class EffectChoice : MonoBehaviour
{
    public delegate void chosenEffect();
    public chosenEffect chosenTag;
    public Text currentlySelectedTag;
    public int selectedChoice;
    public GameObject conButton;
    public GameObject RiskChoice;

    void Start()
    {
        selectedChoice = 0;
    }
    public void ConfirmChoice()
    {
        chosenTag();
        chosenTag = null;
        RiskChoice.SetActive(false);
        selectedChoice = 0;
        Time.timeScale = 1;
    }

    void Update()
    {
        if(currentlySelectedTag != null)
        {
            currentlySelectedTag.text = selectedChoice.ToString();
        }
        if(chosenTag == null)
        {
            conButton.SetActive(false);
        }
        else if(chosenTag != null)
        {
            conButton.SetActive(true);
        }
    }
}
