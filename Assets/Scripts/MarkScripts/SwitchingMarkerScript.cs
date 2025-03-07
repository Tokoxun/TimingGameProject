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
        if(changeTo != DifficultyManager.ShortMarker)
        {
            if(!DifficultyManager.ShortMarker)
            {
                longMarker.SetActive(true);
                shortMarker.SetActive(false);
                changeTo = DifficultyManager.ShortMarker;
            }
            else if(DifficultyManager.ShortMarker)
            {
                longMarker.SetActive(false);
                shortMarker.SetActive(true);
                changeTo = DifficultyManager.ShortMarker;
            }
        }
        if(changeTo == DifficultyManager.ShortMarker)
        {
            return;
        }
    }
}
