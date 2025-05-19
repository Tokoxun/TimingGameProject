using UnityEngine;

public class TimerCondition : ConditionTag
{
    [SerializeField] private float timeCondition = 10f;
    private float currentTimer;

    void Start()
    {
        currentTimer = timeCondition;
    }

    void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer <= 0)
        {
            ConditionExpire();
        }
        else if (currentTimer > 0)
        {
            tempGroupScript.conditionTimer.text = Mathf.Round(currentTimer).ToString();
        }
    }
}
