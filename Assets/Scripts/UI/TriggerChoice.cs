using UnityEngine;

public class TriggerChoice : MonoBehaviour
{
    public EffectChoice effectChoice;
    public TriggerEffects loadEffect;
    public GameObject RisksChoice;
    public RisksCompiler checkListLength;
    private bool targetListLength = false;
    // Start is called before the first frame update
    void Start()
    {
        RisksChoice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(checkListLength.Risks.Count > 0)
        {
            targetListLength = true;
        }
        else if(checkListLength.Risks.Count == 0)
        {
            targetListLength = false;
        }

        if(PlayerLevel.choiceTrigger && targetListLength)
        {
            PlayerLevel.choiceTrigger = false;
            effectChoice.selectedChoice = 0;
            effectChoice.chosenTag = null;
            Time.timeScale = 0;
            RisksChoice.SetActive(true);
            loadEffect.preLoadChoice(checkListLength);
            loadEffect.calculatecardListPlacement();
            loadEffect.loadCard();
        }
    }
}
