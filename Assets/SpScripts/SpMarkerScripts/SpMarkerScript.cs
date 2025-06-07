using UnityEngine;

public class SpMarkerScript : MonoBehaviour
{
    private SpriteRenderer spMarker;
    public bool onHitted;
    public PointSystem pointsScript;
    public SpMarkerRespawn spMarkerRespawn;
    public Collider2D markCol;
    // public AudioManager audioManager;
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
            // audioManager.Play("MarkHitted");
            onHitted = true;
            spMarker.enabled = false;
            markCol.enabled = false;
            pointsScript.AddPoint();
        }
    }
    public void Respawn()
    {
        onHitted = false;
        spMarker.enabled = true;
        markCol.enabled = true;
    }
}
