using UnityEngine;

public class SpSpinScript : MonoBehaviour
{
    [SerializeField] private float dirChangeTime = 2f;
    public float changeTime;
    public float spinSpeed = -100f;
    private float[] changeOrNot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeOrNot = new float[2];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * (spinSpeed * Time.deltaTime));
        if(changeOrNot != null)
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
}
