using UnityEngine;

public class EffectChoiceStarter : MonoBehaviour
{
    public delegate void StarterTag();
    public StarterTag startEffect;
    public GameObject conButton;

    void Start()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void ConfirmEffect()
    {
        startEffect();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if(startEffect == null)
        {
            conButton.SetActive(false);
        }
        else if(startEffect != null)
        {
            conButton.SetActive(true);
        }
    }
}
