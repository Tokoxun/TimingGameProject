using Unity.VisualScripting;
using UnityEngine;

public class BlinkingMarkScript : MonoBehaviour
{
    public GameObject[] activeMarker;
    private GameObject currentMarker;
    public float blinkingTimer = 0.6f;
    public float blinkingTime;
    public float disappearTimer = 0.6f;
    public float disappearTime;

    // Update is called once per frame
    void Update()
    {
        if(activeMarker != null)
        {
            for(int r = 0; r < activeMarker.Length; r++)
            {
                if(activeMarker[r].activeSelf)
                {
                    currentMarker = activeMarker[r];
                }
            }
        }
        if(currentMarker != null && DifficultyManager.mrkBlink)
        {
            if(currentMarker.activeSelf)
            {
                blinkingTime += Time.deltaTime;
                if(blinkingTime >= blinkingTimer)
                {
                    currentMarker.SetActive(false);
                    blinkingTime = 0;
                }
            }
            else if(!currentMarker.activeSelf)
            {
                disappearTime += Time.deltaTime;
                if(disappearTime >= disappearTimer)
                {
                    currentMarker.SetActive(true);
                    disappearTime = 0;
                }
            }
        }
    }
}
