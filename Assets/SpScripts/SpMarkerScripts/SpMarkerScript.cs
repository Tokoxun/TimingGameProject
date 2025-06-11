using UnityEngine;

public class SpMarkerScript : MonoBehaviour
{
    private SpriteRenderer spMarker;
    public SpLevelManager spLevelManager;
    public bool onHitted;
    public markPurplePoint markPurplePoint;
    public markBlackPoint markBlackPoint;
    public PointSystem pointsScript;
    public SpMarkerRespawn spMarkerRespawn;
    public Collider2D markCol;
    public AudioManager audioManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spMarker = this.gameObject.GetComponent<SpriteRenderer>();
        markCol = this.gameObject.GetComponent<PolygonCollider2D>();
        onHitted = false;
        spMarkerRespawn.triggerRespawn += Respawn;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("point"))
        {
            spMarkerRespawn.randomizeCooldown();
            audioManager.Play("MarkHitted");
            onHitted = true;
            spMarker.enabled = false;
            markCol.enabled = false;
            pointsScript.AddPoint(1);
        }
    }
    public void Respawn()
    {
        if (markPurplePoint != null && spLevelManager.warningSwitch)
        {
            markPurplePoint.StartEffect();
        }
        else if (markBlackPoint != null && spLevelManager.mineSwitch)
        {
            markBlackPoint.StartEffect();
        }
        onHitted = false;
        spMarker.enabled = true;
        markCol.enabled = true;
    }
}
