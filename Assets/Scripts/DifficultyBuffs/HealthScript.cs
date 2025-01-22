using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float Max_health = 3;
    public float health = 3;
    public float HpRedc = 1;
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
        Debug.Log(health);
        if(health <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("You lose");
        }
    }
}
