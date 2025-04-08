using UnityEngine;

public class hittingScript : MonoBehaviour
{
    public SpriteRenderer hitterSprite;
    public CooldownSlider displaySliderCooldown;
    private bool actvCooldown = false;
    private float cooldown;
    private float hitterCooldown = 1f;
    private float totalCooldown;
    private float hitReset = 0.2f;
    private float Resettimer;
    public Collider2D hitPoint;
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
            displaySliderCooldown.TriggerSliderCooldown(totalCooldown);
            resetComboTimer.ResetTimer();
            calCombo.AddCombo();
            hitPoint.enabled = false;
            Resettimer = 0;
            actvCooldown = true;
        }
    }

    void Update()
    {
        if(DifficultyManager.displayHitterSprite)
        {
            hitterSprite.enabled = false;
        }
        totalCooldown = hitterCooldown + DifficultyManager.addButtonCooldown;
        if(actvCooldown && hitterSprite != null)
        {
            cooldown += Time.deltaTime;
            if(cooldown > totalCooldown)
            {
                hitterSprite.enabled = true;
                cooldown = 0;
                actvCooldown = false;
            }
            else if(cooldown < totalCooldown)
            {
                hitterSprite.enabled = false;
                hitPoint.enabled = false;
            }
        }
        if(hitPoint.enabled == true)
        {
            Resettimer += Time.deltaTime;
            if(Resettimer >= hitReset)
            {
                displaySliderCooldown.TriggerSliderCooldown(totalCooldown);
                calCombo.ResetCombo();
                calHealth.ReduceHealth();
                hitPoint.enabled = false;
                Resettimer = 0;
                actvCooldown = true;
            }
        }
    }
}
