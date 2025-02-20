using UnityEngine;

public class ButtonCooldown : MonoBehaviour
{
    private float frstCooldown = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DifficultyManager.addButtonCooldown += frstCooldown;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
