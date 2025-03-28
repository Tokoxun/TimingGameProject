using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private Slider levelSlider;
    public Text levelNum;
    public int playerLevel;
    public float increaseSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        increaseSpeed = 1f;
        playerLevel = 0;
        levelSlider = this.gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(levelSlider.value < levelSlider.maxValue)
        {
            levelSlider.value += increaseSpeed * Time.deltaTime;
        }
        else if(levelSlider.value >= levelSlider.maxValue)
        {
            playerLevel += 1;
            levelNum.text = playerLevel.ToString();
            levelSlider.value = 0;
        }
    }
}
