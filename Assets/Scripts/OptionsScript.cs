using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public Dropdown displayOption;
    // Update is called once per frame
    void Update()
    {
        if(displayOption.value == 0)
        {
            Screen.SetResolution(941, 701, false);
        }
        else if(displayOption.value == 1)
        {
            Screen.SetResolution(1920, 1080, true);
        }
    }
}
