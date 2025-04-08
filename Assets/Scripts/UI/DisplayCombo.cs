using UnityEngine;
using UnityEngine.UI;

public class DisplayCombo : MonoBehaviour
{
    public GameObject ComboDisplay;
    public Text comboNumber;
    public int currentCombo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCombo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        comboNumber.text = currentCombo.ToString();
        if(currentCombo == 0)
        {
            ComboDisplay.SetActive(false);
        }
        else if(currentCombo != 0)
        {
            ComboDisplay.SetActive(true);
        }
    }

    public void AddCombo()
    {
        currentCombo += 1;
    }

    public void ResetCombo()
    {
        currentCombo = 0;
    }
}
