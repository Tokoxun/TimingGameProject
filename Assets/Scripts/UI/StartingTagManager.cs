using UnityEngine;

public class StartingTagManager : MonoBehaviour
{
    public GameObject equipTimer;
    public GameObject equipHealth;
    public GameObject currentEquip;
    void Update()
    {
        if (TimerTrigger.startTimer)
        {
            currentEquip = equipTimer;
        }
        else if (HealthScriptTrigger.startHealth)
        {
            currentEquip = equipHealth;
        }
        if (currentEquip != null)
        {
            currentEquip.SetActive(true);
            if (!HealthScriptTrigger.startHealth && !TimerTrigger.startTimer)
            {
                currentEquip.SetActive(false);
                currentEquip = null;
            }
        }
    }

    void OnDisable()
    {
        TimerTrigger.startTimer = false;
        HealthScriptTrigger.startHealth = false;
        equipHealth.SetActive(false);
        equipTimer.SetActive(false);
        currentEquip = null;
    }
}
