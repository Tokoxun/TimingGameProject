using UnityEngine;

public class EffectChoice : MonoBehaviour
{
    public delegate void chosenEffect();
    public static chosenEffect chosenTag;
    public GameObject conButton;
    public GameObject RiskChoice;
    public void ConfirmChoice()
    {
        chosenTag();
        chosenTag = null;
        RiskChoice.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
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
