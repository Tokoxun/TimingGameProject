using UnityEngine;

public class MarkerSpinScript : MonoBehaviour
{
    private float dirChangeTime = 1f;
    public float changeTime;
    private float[] changeOrNot;
    public float spinSpeed = -35f;
    public float buffedSpnSpd;
    public float totalBuffedSpnSpd;
    public float levelbuffedSpnSpd;
    public float currentRotation;

    void Start()
    {
        changeOrNot = new float[2];
        changeOrNot[0] = spinSpeed;
        changeOrNot[1] = -spinSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        buffedSpnSpd = (DifficultyManager.addMrkSpd - DifficultyManager.decreaseMrkSpd) / 100;
        totalBuffedSpnSpd = spinSpeed * buffedSpnSpd;
        levelbuffedSpnSpd = spinSpeed * LevelManager.levelSpeed;
        transform.Rotate(Vector3.forward * (spinSpeed + totalBuffedSpnSpd + levelbuffedSpnSpd) * Time.deltaTime);
        if(changeOrNot != null && DifficultyManager.rotateMarker)
        {
            changeOrNot[0] = spinSpeed;
            changeOrNot[1] = -spinSpeed;
            changeTime += Time.deltaTime;
            if(changeTime >= dirChangeTime)
            {
                spinSpeed = changeOrNot[Random.Range(0, changeOrNot.Length)];
                changeTime = 0;
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
