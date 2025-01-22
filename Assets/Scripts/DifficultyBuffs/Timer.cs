using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public float timeSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= timeSpeed*Time.deltaTime;
        if(timer <= 0)
        {
            Debug.Log("Times up");
        }
    }
}
