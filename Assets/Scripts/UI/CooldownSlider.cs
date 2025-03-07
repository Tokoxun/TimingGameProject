using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class CooldownSlider : MonoBehaviour
{
    private Slider sliderDisplay;
    public float min_value;

    void Start()
    {
        sliderDisplay = gameObject.GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        if(min_value <= 0)
        {
            this.gameObject.SetActive(false);
        }
        if(min_value > 0)
        {
            min_value -= Time.deltaTime;
            sliderDisplay.value = min_value;
        }
    }

    public void TriggerSliderCooldown(float max_value)
    {
        sliderDisplay.maxValue = max_value;
        sliderDisplay.value = max_value;
        min_value = max_value;
        this.gameObject.SetActive(true);
    }
}
