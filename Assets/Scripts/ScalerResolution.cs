using UnityEngine;

public class ScalerResolution : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Screen.height);
        Debug.Log(Screen.width);
        Screen.SetResolution(941, 701, false);
        // Screen.SetResolution(1280, 720, false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
