using JetBrains.Annotations;
using UnityEngine;

public class markBlackPoint : MonoBehaviour
{
    public GameManager gameManager;
    public SpLevelManager spLevelManager;
    public SpMarkerScript spMarkerScript;
    private float effectTimer = 3f;
    public float effectTime;
    private bool chosenEnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (spLevelManager.mineSwitch)
        {
            effectTime += Time.deltaTime;
            if (effectTime >= effectTimer)
            {
                StopEffect();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            gameManager.GameOver();
        }
    }
    public void StartEffect()
    {
        this.gameObject.SetActive(true);
        chosenEnd = true;
    }

    public void StopEffect()
    {
        effectTime = 0;
        this.gameObject.SetActive(false);
        chosenEnd = false;
    }
}
