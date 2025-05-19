using UnityEngine;
using UnityEngine.UI;

public class TempGroupScript : MonoBehaviour
{
    public delegate void resetTempDelegate();
    public resetTempDelegate resetAllTemp;
    public PlayerLevel levelCheck;
    private bool activated;
    private bool deployed;
    public TempTagSlot leftSlot;
    public TempTagSlotRight rightSlot;
    public Text conditionTimer;
    public int levelTrigger;
    private int triggerInterval = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resetAllTemp += leftSlot.RemoveTag;
        resetAllTemp += rightSlot.RemoveCondition;
        activated = false;
        levelTrigger = levelCheck.playerLevel + triggerInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelCheck.playerLevel >= levelTrigger && !activated)
        {
            leftSlot.GetTags();
            rightSlot.GetCondition();
            activated = true;
        }
        if(leftSlot.selectedTag != null && rightSlot.selectedCondition != null)
        {
            if(!deployed)
            {
                EffectTag leftEffectTag = leftSlot.selectedTag.GetComponent<EffectTag>();
                rightSlot.selectedCondition.SetLink(leftEffectTag, this.gameObject.GetComponent<TempGroupScript>());
                Instantiate(rightSlot.selectedCondition);
                deployed = true;
            }
        }
        if(rightSlot.selectedCondition == null && activated)
        {
            levelTrigger = levelCheck.playerLevel + triggerInterval;
            conditionTimer.text = null;
            activated = false;
            deployed = false;
        }
    }
}
