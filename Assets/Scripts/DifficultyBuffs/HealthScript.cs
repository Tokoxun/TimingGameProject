using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class HealthScript : MonoBehaviour
{
    public float Max_health = 3;
    public float health = 3;
    public float HpRedc = 1;
    public Text HealthDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ReduceHealth()
    {
        health -= HpRedc;
    }

    // Update is called once per frame
    void Update()
    {
        HealthDisplay.text = health.ToString();
        if(health <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("You lose");
        }
    }
}
