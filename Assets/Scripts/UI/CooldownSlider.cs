using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class CooldownSlider : MonoBehaviour
{
    private Slider sliderDisplay;
    public float min_value;
    public bool actvCooldown = false;
    private float cooldown;
    [SerializeField] private float hitterCooldown = 1f;
    private float totalCooldown;

    void Start()
    {
        sliderDisplay = gameObject.GetComponent<Slider>();
        sliderDisplay.maxValue = hitterCooldown;
        sliderDisplay.value = hitterCooldown;
    }
    // Update is called once per frame
    void Update()
    {
        // if(min_value <= 0)
        // {
        //     this.gameObject.SetActive(false);
        // }
        if (min_value > 0)
        {
            min_value -= Time.deltaTime;
            sliderDisplay.value = min_value;
        }
        totalCooldown = hitterCooldown + DifficultyManager.addButtonCooldown;
        if (actvCooldown)
        {
            cooldown += Time.deltaTime;
            if (cooldown > totalCooldown)
            {
                cooldown = 0;
                actvCooldown = false;
            }
            else if (cooldown < totalCooldown)
            {
                sliderDisplay.value += Time.deltaTime;
            }
        }
    }

    public void TriggerSliderCooldown()
    {
        sliderDisplay.maxValue = totalCooldown;
        sliderDisplay.value = 0;
        actvCooldown = true;
    }
}
