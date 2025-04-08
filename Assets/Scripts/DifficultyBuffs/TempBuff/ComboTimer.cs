using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ComboTimer : MonoBehaviour
{
    public DisplayCombo comboCounter;
    public Slider timer;
    private bool startTimer;
    public static float maxResetTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        startTimer = false;
        timer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(maxResetTimer <= 0)
        {
            timer.gameObject.SetActive(false);
            timer.maxValue = maxResetTimer;
            timer.value = maxResetTimer;
            startTimer = false;
        }
        if(maxResetTimer > 0 && timer.value == 0)
        {
            timer.gameObject.SetActive(true);
            timer.maxValue = maxResetTimer;
            timer.value = maxResetTimer;
            startTimer = true;
        }
        if(timer.value > 0)
        {
            timer.value -= Time.deltaTime;
        }
        if(startTimer && timer.value <= 0)
        {
            comboCounter.ResetCombo();
        }
    }


    public static void SetTimer(float timerSet)
    {
        maxResetTimer = timerSet;
    }

    public void ResetTimer()
    {
        if(timer.enabled)
        {
            timer.value = maxResetTimer;
        }
    }
}
