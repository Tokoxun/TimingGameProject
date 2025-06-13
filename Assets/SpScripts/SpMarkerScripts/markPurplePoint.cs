using UnityEngine;

public class markPurplePoint : MonoBehaviour
{
    public GameManager gameManager;
    public SpMarkerScript markerScript;
    public bool chosenEnd;
    private float endTimer = 5f;
    public float endTime;
    private Animator pointAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.SetActive(false);
        chosenEnd = false;
        pointAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (markerScript.spLevelManager.warningSwitch && chosenEnd)
        {
            endTime += Time.deltaTime;
            pointAnimator.speed = endTime;
            if (endTime >= endTimer)
            {
                gameManager.GameOver();
            }
            else if (markerScript.onHitted)
            {
                endTime = 0;
                chosenEnd = false;
                this.gameObject.SetActive(false);
                return;
            }
        }
    }

    public void StartEffect()
    {
        this.gameObject.SetActive(true);
        chosenEnd = true;
    }

    public void StopEffect()
    {
        this.gameObject.SetActive(false);
        chosenEnd = false;
    }
}
