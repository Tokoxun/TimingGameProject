using UnityEngine;

public class SwitchingMarkerScript : MonoBehaviour
{
    public GameObject longMarker;
    public GameObject shortMarker;
    private bool changeTo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeTo = false;
    }

    // Update is called once per frame
    void Update()
    {
        changeTo = DifficultyManager.ShortMarker;
        if(!changeTo)
        {
            longMarker.SetActive(true);
            shortMarker.SetActive(false);
        }
        else if(changeTo)
        {
            longMarker.SetActive(false);
            shortMarker.SetActive(true);
        }
    }
}
