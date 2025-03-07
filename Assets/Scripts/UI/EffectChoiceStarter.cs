using UnityEngine;

public class EffectChoiceStarter : MonoBehaviour
{
    public delegate void StarterTag();
    public StarterTag startEffect;
    public GameObject conButton;
    
    public void ConfirmEffect()
    {
        startEffect();
        gameObject.SetActive(false);
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
