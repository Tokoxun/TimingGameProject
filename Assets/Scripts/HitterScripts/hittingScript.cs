using UnityEngine;

public class hittingScript : MonoBehaviour
{
    private SpriteRenderer hitterSprite;
    private bool actvCooldown = false;
    private float cooldown;
    private float hitterCooldown = 1f;
    private float totalCooldown;
    private float hitReset = 0.2f;
    private float Resettimer;
    public Collider2D hitPoint;
    public DisplayCombo calCombo;
    public PointSystem addingPoint;
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
            calCombo.AddCombo();
            addingPoint.AddPoint();
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
                calCombo.ResetCombo();
                calHealth.ReduceHealth();
                hitPoint.enabled = false;
                Resettimer = 0;
                actvCooldown = true;
            }
        }
    }
}
