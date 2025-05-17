using UnityEngine;
using UnityEngine.UI;

public class TagReroll : MonoBehaviour
{
    private Button rerollButton;
    public Text rerollCount;
    private int maxReroll = 3;
    private int currentReroll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rerollButton = gameObject.GetComponent<Button>();
        currentReroll = maxReroll;
    }

    // Update is called once per frame
    void Update()
    {
        if(rerollCount != null)
        {
            rerollCount.text = currentReroll.ToString();
        }
        if(rerollButton != null)
        {
            if(currentReroll <= 0)
            {
                rerollButton.interactable = false;
            }
            else if(currentReroll > 0)
            {
                rerollButton.interactable = true;
            }
        }
    }

    public void ReduceCount()
    {
        if(rerollButton != null && rerollCount != null)
        {
            currentReroll -= 1;
        }
    }
}
