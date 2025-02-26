using UnityEngine;
using UnityEngine.UI;

public class ButtonHitterText : MonoBehaviour
{
    public Text currentButtonText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(currentButtonText != null)
        {
            currentButtonText.text = DifficultyManager.currentInput;
        }
    }
}
