using UnityEngine;

public class TimerCondition : ConditionTag
{
    private float timeCondition = 10f;
    private float currentTimer;

    void Update()
    {
        currentTimer += Time.deltaTime;
        if(currentTimer >= timeCondition)
        {
            tempGroupScript.resetAllTemp();
        }
    }
}
