using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitterChoice : MonoBehaviour
{
    public InputAction changeInput;
    private string currentButton;
    public GameObject enablShortHitter;
    public GameObject enablLongHitter;
    public Collider2D hitPointLong;
    public Collider2D hitPointShort;
    // Start is called before the first frame update
    void Start()
    {
        currentButton = DifficultyManager.currentInput;
        changeInput.Enable();
        enablShortHitter.SetActive(false);
        enablLongHitter.SetActive(true);
    }

    public void OnButtonHit()
    {
        if(enablLongHitter.activeSelf)
        {
            hitPointLong.enabled = true;
        }
        else if(enablShortHitter.activeSelf)
        {
            hitPointShort.enabled = true;
        }
    }

    void Update()
    {
        enablLongHitter.SetActive(DifficultyManager.LongHitter);
        enablShortHitter.SetActive(DifficultyManager.ShortHitter);
        changeInput.ChangeBinding(0).WithPath($"<Keyboard>/{DifficultyManager.currentInput}");
        if(changeInput.triggered)
        {
            if(enablLongHitter.activeSelf)
            {
                hitPointLong.enabled = true;
            }
            else if(enablShortHitter.activeSelf)
            {
                hitPointShort.enabled = true;
            }
        }
        if(currentButton != DifficultyManager.currentInput)
        {
            currentButton = DifficultyManager.currentInput;
            Debug.Log(currentButton);
        }
    }

    public void DisableControl()
    {
        changeInput.Disable();
    }
}
