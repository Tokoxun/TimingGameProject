using TMPro;
using UnityEngine;
public class InputChange : MonoBehaviour
{
    private string[] totalInput;
    private string chosenInput;
    public TextMeshProUGUI currentButtonText;
    private float changeInput;
    private float changeTimer = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalInput = new string[27] 
        {"A", "B", "C", "D", "E", 
        "F", "G", "H", "I", "J", 
        "K", "L", "M", "N", "O", 
        "P", "Q", "R", "S", "T", 
        "U", "V", "W", "X", "Y", 
        "Z", "Space"};
    }

    // Update is called once per frame
    void Update()
    {
        if(DifficultyManager.initInputChange && currentButtonText != null)
        {
            changeInput += Time.deltaTime;
            if(changeInput > changeTimer)
            {
                chosenInput = totalInput[Random.Range(0, totalInput.Length)];
                DifficultyManager.currentInput = chosenInput;
                currentButtonText.text = DifficultyManager.currentInput;
                changeInput = 0;
            }
        }
        else if(!DifficultyManager.initInputChange)
        {
            chosenInput = null;
            DifficultyManager.currentInput = "Space";
            currentButtonText.text = DifficultyManager.currentInput;
        }
    }
}
