using UnityEngine;

public class SpSpinScript : MonoBehaviour
{
    [SerializeField] private float dirChangeTime = 2f;
    public float changeTime;
    public SpLevelManager spLevelManager;
    private float totalSpinSpeed;
    public float spinSpeed = -100f;
    private float[] changeOrNot;
    public float signalTime = 1f;
    private float change;
    public GameObject[] turnSignal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeOrNot = new float[2];
        change = spinSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        totalSpinSpeed = spinSpeed + (spinSpeed * spLevelManager.levelDiff);
        transform.Rotate(Vector3.forward * (totalSpinSpeed * Time.deltaTime));
        if(changeOrNot != null && spLevelManager.hitterSwitch)
        {
            changeOrNot[0] = spinSpeed;
            changeOrNot[1] = -spinSpeed;
            changeTime += Time.deltaTime;
            if (dirChangeTime - changeTime <= signalTime && change != spinSpeed)
            {
                if (spinSpeed > 0)
                {
                    turnSignal[1].SetActive(true);
                }
                else if (spinSpeed < 0)
                {
                    turnSignal[0].SetActive(true);
                }
            }
            if (changeTime >= dirChangeTime)
            {
                spinSpeed = change;
                change = changeOrNot[Random.Range(0, changeOrNot.Length)];
                changeTime = 0;
                turnSignal[0].SetActive(false);
                turnSignal[1].SetActive(false);
            }
        }
    }
}
