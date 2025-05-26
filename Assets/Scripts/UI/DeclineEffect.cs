using UnityEngine;

public class DeclineEffect : MonoBehaviour
{
    public TriggerEffects triggerEffects;
    private InfoTag tagNumber;
    public PlayerLevel levelPenalty;
    public GameObject RiskChoice;

    public void DeclineOffer()
    {
        for(int p = 0; p < triggerEffects.selectedFilter.Count; p++)
        {
            if(triggerEffects.selectedFilter[p].GetComponent<InfoTag>() != null)
            {
                tagNumber = triggerEffects.selectedFilter[p].GetComponent<InfoTag>();
                levelPenalty.playerLevel += tagNumber.details[tagNumber.detailLevel].rNumber;
            }
        }
        RiskChoice.SetActive(false);
        Time.timeScale = 1;
    }
}
