using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public UIManager triggerGameOver;
    private float Max_health = 3;
    [SerializeField] private float health = 3;
    public float HpRedc = 1;
    public Text HealthDisplay;
    public Slider recoveryBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ReduceHealth()
    {
        health -= HpRedc;
    }
    public void RecoverHealth(int comboRec)
    {
        if(recoveryBar != null)
        {
            if(recoveryBar.maxValue > 0)
            {
                recoveryBar.value += 1 + (comboRec / 100);
            }
            if(recoveryBar.value >= recoveryBar.maxValue)
            {
                health += 1;
                recoveryBar.value = 0;
            }
        }
        else if(health > Max_health)
        {
            health = Max_health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HealthDisplay.text = health.ToString();
        if (health <= 0)
        {
            triggerGameOver.TriggerGameOver();
        }
        if(health > Max_health)
        {
            health = Max_health;
        }
    }
}
