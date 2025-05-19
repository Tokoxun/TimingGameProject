using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public UIManager triggerGameOver;
    public Text TimerDisplay;
    public float timer = 60;
    public float timeSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= timeSpeed * Time.deltaTime;
        TimerDisplay.text = Mathf.Round(timer).ToString();
        if (timer <= 0)
        {
            timer = 0;
            triggerGameOver.TriggerGameOver();
        }
    }
}
