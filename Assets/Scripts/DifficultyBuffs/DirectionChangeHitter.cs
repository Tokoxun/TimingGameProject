using UnityEngine;

public class DirectionChangeHitter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        SpinScript.EnableSwitchDirection();
    }

    private void OnDisable()
    {
        SpinScript.DisableSwitchDirection();
    }
}
