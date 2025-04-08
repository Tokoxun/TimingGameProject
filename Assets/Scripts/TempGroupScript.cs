using UnityEngine;

public class TempGroupScript : MonoBehaviour
{
    public delegate void resetTemp();
    public resetTemp resetAllTemp;
    public PlayerLevel levelCheck;
    private bool activated;
    public TempTagSlot leftSlot;
    public TempTagSlotRight rightSlot;
    public int levelTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activated = false;
        levelTrigger = levelCheck.playerLevel + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelCheck.playerLevel >= levelTrigger && !activated)
        {
            resetAllTemp = null;
            leftSlot.GetTags();
            rightSlot.GetCondition();
            activated = true;
        }
        if(rightSlot.selectedCondition == null && activated)
        {
            levelTrigger = levelCheck.playerLevel + 1;
            activated = false;
        }
    }
}
