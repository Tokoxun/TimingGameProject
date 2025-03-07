using UnityEngine;

public class ButtonCooldown : MonoBehaviour
{
    private float frstCooldown = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        DifficultyManager.addButtonCooldown += frstCooldown;
    }

    void OnDisable()
    {
        DifficultyManager.addButtonCooldown -= frstCooldown;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
