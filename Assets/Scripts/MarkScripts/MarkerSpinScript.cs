using UnityEngine;

public class MarkerSpinScript : MonoBehaviour
{
    public float spinSpeed = -35f;
    public float buffedSpnSpd;
    public float totalBuffedSpnSpd;

    // Update is called once per frame
    void Update()
    {
        buffedSpnSpd = (DifficultyManager.addMrkSpd - DifficultyManager.decreaseMrkSpd) / 100;
        totalBuffedSpnSpd = spinSpeed * buffedSpnSpd;
        if(buffedSpnSpd != 0)
        {
            transform.Rotate(Vector3.forward * (spinSpeed + totalBuffedSpnSpd) * Time.deltaTime);
        }
        if(buffedSpnSpd == 0)
        {
            transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        }
    }
}
