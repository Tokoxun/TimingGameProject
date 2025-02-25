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
        {"<Keyboard>/a", "<Keyboard>/b", "<Keyboard>/c", "<Keyboard>/d", "<Keyboard>/e", 
        "<Keyboard>/f", "<Keyboard>/g", "<Keyboard>/h", "<Keyboard>/i", "<Keyboard>/j", 
        "<Keyboard>/k", "<Keyboard>/l", "<Keyboard>/m", "<Keyboard>/n", "<Keyboard>/o", 
        "<Keyboard>/p", "<Keyboard>/q", "<Keyboard>/r", "<Keyboard>/s", "<Keyboard>/t", 
        "<Keyboard>/u", "<Keyboard>/v", "<Keyboard>/w", "<Keyboard>/x", "<Keyboard>/y", 
        "<Keyboard>/z", "<Keyboard>/space"};
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
        DifficultyManager.currentInput = "<Keyboard>/space";
    }
}
