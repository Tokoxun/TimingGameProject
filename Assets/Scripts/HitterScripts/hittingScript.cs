using UnityEngine;

public class hittingScript : MonoBehaviour
{
    public SpriteRenderer hitterSprite;
    public CooldownSlider displaySliderCooldown;
    private float hitReset = 0.2f;
    private float Resettimer;
    public Collider2D hitPoint;
    public PlayerLevel levelProgress;
    public DisplayCombo calCombo;
    public ComboTimer resetComboTimer;
    public HealthScript calHealth;
    
    // public void OnButtonPressLong()
    // {
    //     hitPoint.enabled = true;
    //     hitted = true;
    // }

    void Start()
    {
        hitterSprite = gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("target"))
        {
            displaySliderCooldown.TriggerSliderCooldown();
            resetComboTimer.ResetTimer();
            calHealth.RecoverHealth(calCombo.currentCombo);
            calCombo.AddCombo();
            levelProgress.progressJump();
            hitPoint.enabled = false;
            Resettimer = 0;
        }
    }

    void Update()
    {
        if(DifficultyManager.displayHitterSprite)
        {
            hitterSprite.enabled = false;
        }
        if (displaySliderCooldown.actvCooldown)
        {
            hitterSprite.enabled = false;
            hitPoint.enabled = false;
        }
        else if (!displaySliderCooldown.actvCooldown)
        {
            hitterSprite.enabled = true;
        }
        if (hitPoint.enabled == true)
            {
                Resettimer += Time.deltaTime;
                if (Resettimer >= hitReset)
                {
                    displaySliderCooldown.TriggerSliderCooldown();
                    calCombo.ResetCombo();
                    calHealth.ReduceHealth();
                    hitPoint.enabled = false;
                    Resettimer = 0;
                }
            }
    }
}
