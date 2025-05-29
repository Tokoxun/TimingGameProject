using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    private Slider levelSlider;
    public TextMeshProUGUI levelNum;
    public int playerLevel;
    public float increaseSpeed;
    public static bool choiceTrigger = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        choiceTrigger = false;
        levelSlider = this.gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        levelNum.text = playerLevel.ToString();
        if(increaseSpeed > 0)
        {
            if(levelSlider.value < levelSlider.maxValue)
            {
                levelSlider.value += increaseSpeed * Time.deltaTime;
            }
            else if(levelSlider.value >= levelSlider.maxValue)
            {
                choiceTrigger = true;
                playerLevel += 1;
                levelSlider.value = 0;
            }
        }
    }

    public void progressJump()
    {
        levelSlider.value += 3;
    }
    public void StopLeveling()
    {
        increaseSpeed = 0;
    }
}
