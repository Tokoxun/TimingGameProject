using System.Collections.Generic;
using UnityEngine;

public class EffectChoiceStarter : MonoBehaviour
{
    public delegate void StarterTag();
    public StarterTag startEffect;
    public GameObject conButton;
    private bool choseStart = false;
    public List<CardScriptsStarter> cardStarter;

    void Start()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        choseStart = false;
    }
    public void ConfirmEffect()
    {
        startEffect();
        gameObject.SetActive(false);
        Time.timeScale = 1;
        choseStart = true;
    }

    void Update()
    {
        if (startEffect == null)
        {
            conButton.SetActive(false);
        }
        else if (startEffect != null)
        {
            conButton.SetActive(true);
        }
        if (!choseStart)
        {
            if (cardStarter.Count > 1)
            {
                cardStarter[0].selectedAnimation.SetBool("selected", false);
                cardStarter[0].Chosen = false;
                cardStarter.Remove(cardStarter[0]);
            }
        }
    }
}
