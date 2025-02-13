using UnityEngine;
using UnityEngine.UI;

public class DisplayCombo : MonoBehaviour
{
    public Text comboNumber;
    private int currentCombo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCombo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        comboNumber.text = currentCombo.ToString();
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
