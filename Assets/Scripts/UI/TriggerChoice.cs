using UnityEngine;

public class TriggerChoice : MonoBehaviour
{
    public PointSystem pointsCheck;
    public TriggerEffects loadEffect;
    public GameObject RisksChoice;
    public int displayChoice = 5;
    public RisksCompiler checkListLength;
    private bool targetListLength = false;
    private bool signal = false;
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
            Time.timeScale = 0;
            RisksChoice.SetActive(true);
            loadEffect.preLoadChoice();
            loadEffect.calculatecardListPlacement();
            loadEffect.loadCard();
            signal = false;
        }
    }
}
