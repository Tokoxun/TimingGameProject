using UnityEngine;
using UnityEngine.InputSystem;
public class SPHitTriggerScript : MonoBehaviour
{
    public GameManager gameManager;
    public InputAction inputAction;
    public GameObject hitterObject;
    [SerializeField] private float cooldownTimer = 0.5f;
    [SerializeField] private float hitCooldown;
    public SpHitScript spHitScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager.gameOverEvent += stopButton;
        inputAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction.triggered)
        {
            spHitScript.hitPoint.enabled = true;
        }
        if (spHitScript.onCooldown)
        {
            hitCooldown += Time.deltaTime;
            if (hitCooldown >= cooldownTimer)
            {
                spHitScript.hitterSprite.enabled = true;
                spHitScript.onCooldown = false;
                hitCooldown = 0;
            }
            else if (hitCooldown < cooldownTimer)
            {
                spHitScript.hitPoint.enabled = false;
                spHitScript.hitterSprite.enabled = false;
            }
        }
    }

    public void stopButton()
    {
        inputAction.Disable();
    }
}
