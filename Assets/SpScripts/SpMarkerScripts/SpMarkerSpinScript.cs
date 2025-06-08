using UnityEngine;

public class SpMarkerSpinScript : MonoBehaviour
{
    [SerializeField] private float dirChangeTime = 2f;
    public float changeTime;
    private float switchPlacementTimer = 8f;
    private float switchPlacement;
    private float[] changeOrNot;
    public float spinSpeed = -35f;
    public SpLevelManager spLevelManager;
    private float totalSpinSpeed;
    public float currentRotation;
    public SpMarkerRespawn spMarkerRespawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeOrNot = new float[2];
        spMarkerRespawn.triggerRespawn += randomCurrentMarkPosition;
    }

    // Update is called once per frame
    void Update()
    {
        totalSpinSpeed = spinSpeed + (spinSpeed * spLevelManager.levelDiff);
        transform.Rotate(Vector3.forward * (totalSpinSpeed * Time.deltaTime));
        if (changeOrNot != null)
        {
            changeOrNot[0] = spinSpeed;
            changeOrNot[1] = -spinSpeed;
            changeTime += Time.deltaTime;
            if (changeTime >= dirChangeTime)
            {
                spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
                changeTime = 0;
            }
        }
        if (spLevelManager.startSwitch)
        {
            switchPlacement += Time.deltaTime;
            if (switchPlacement >= switchPlacementTimer)
            {
                randomCurrentMarkPosition();
                switchPlacement = 0;
            }
        }
    }
    public void randomCurrentMarkPosition()
    {
        spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
        currentRotation = Random.Range(0, 361);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }
}
