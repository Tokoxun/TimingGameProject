using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Timer : MonoBehaviour
{
    public Text TimerDisplay;
    public float timer = 60;
    public float timeSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerDisplay.text = timer.ToString();
        if(timer <= 0)
        {
            timer = 0;
            Time.timeScale = 0;
            Debug.Log("Times up");
        }
        else if(timer > 0)
        {
            timer -= timeSpeed*Time.deltaTime;
        }
    }
}
