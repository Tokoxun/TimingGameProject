using UnityEngine;

public class InputChange : MonoBehaviour
{
    private string[] totalInput;
    private string chosenInput;
    private float changeInput;
    private float changeTimer = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalInput = new string[27] 
        {"a", "b", "c", "d", "e", 
        "f", "g", "h", "i", "j", 
        "k", "l", "m", "n", "o", 
        "p", "q", "r", "s", "t", 
        "u", "v", "w", "x", "y", 
        "z", "space"};
    }

    // Update is called once per frame
    void Update()
    {
        changeInput += Time.deltaTime;
        if(changeInput > changeTimer)
        {
            chosenInput = totalInput[Random.Range(0, totalInput.Length)];
            DifficultyManager.currentInput = chosenInput;
            changeInput = 0;
        }
    }

    void OnDisable()
    {
        chosenInput = null;
        DifficultyManager.currentInput = "space";
    }
}
