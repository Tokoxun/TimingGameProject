using UnityEngine;
using UnityEngine.UI;
public class VariableHit : MonoBehaviour
{
    public Text numberText;
    private static int variableNum;
    public Transform markPosition;
    public Transform centerPointRotation;
    private float Xscale;
    private float Yscale;

    void Start()
    {
        float screenX = Screen.width;
        float screenY = Screen.height;
        Xscale = Mathf.Round(screenX / 11);
        Yscale = Mathf.Round(screenY / 5);

    }
    // Update is called once per frame
    void Update()
    {
        if(DifficultyManager.displayVariableNum)
        {
            numberText.enabled = true;
            numberText.rectTransform.localScale = markPosition.transform.localScale;
            numberText.rectTransform.localPosition = new Vector2(markPosition.position.x * Xscale, markPosition.position.y * Yscale);
            numberText.rectTransform.localRotation = centerPointRotation.rotation;
            numberText.text = variableNum.ToString();
        }
        if(variableNum <= 0)
        {
            numberText.enabled = false;
        }
    }

    public void decreaseNum()
    {
        variableNum -= 1;
    }

    public static void randomVariable()
    {
        variableNum = Random.Range(1, 11);
    } 
}
