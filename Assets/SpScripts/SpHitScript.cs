using UnityEngine;

public class SpHitScript : MonoBehaviour
{
    public SpriteRenderer hitterSprite;
    private float hitReset = 0.2f;
    private float Resettimer;
    public bool onCooldown;
    public Collider2D hitPoint;

    void Start()
    {
        hitterSprite = gameObject.GetComponent<SpriteRenderer>();
        hitPoint = this.gameObject.GetComponent<BoxCollider2D>();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("target"))
        {
            hitPoint.enabled = false;
            Resettimer = 0;
            onCooldown = true;
        }
    }

    void Update()
    {
        if (hitPoint.enabled == true)
        {
            Resettimer += Time.deltaTime;
            if (Resettimer >= hitReset)
            {
                hitPoint.enabled = false;
                Resettimer = 0;
                onCooldown = true;
            }
        }
    }
}
