using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject resultScreen;
    public UIManager subscribeGameOverEvent;
    public PointSystem calPoint;
    public TagInventory tagRNum;
    public Text pointText;
    private int pointGotten;
    private bool doneCalculatePoint;
    public Text riskText;
    private int totalRisk;
    private bool doneCalculateRisk;
    public Text totalPointsText;
    private int totalPoints;

    void Start()
    {
        resultScreen.SetActive(false);
        doneCalculatePoint = false;
        doneCalculateRisk = false;
    }
    public void DisplayResult()
    {
        resultScreen.SetActive(true);
        StartCoroutine(CalculatePoints());
    }

    IEnumerator CalculatePoints()
    {
        if(calPoint != null && tagRNum != null)
        {
            if(calPoint.points > 0 && !doneCalculatePoint)
            {
                pointGotten = calPoint.points;
                doneCalculatePoint = true;
            }
            yield return new WaitForSeconds(2f);
            if(tagRNum.selectedTags.Count > 0 && !doneCalculateRisk)
            {
                foreach(GameObject r in tagRNum.selectedTags)
                {
                    InfoTag getRNumber = r.GetComponent<InfoTag>();
                    totalRisk += getRNumber.rNumber;
                    Debug.Log("Calculating R");
                }
                doneCalculateRisk = true;
            }
            else if(calPoint.points <= 0)
            {
                pointGotten = calPoint.points;
            }
            else if(tagRNum.selectedTags.Count <= 0)
            {
                totalRisk = 0;
            }
        }
        if(doneCalculatePoint && doneCalculateRisk)
        {
            pointText.text = pointGotten.ToString();
            riskText.text = totalRisk.ToString();
            totalPointsText.text = totalPoints.ToString();
            StopCoroutine(CalculatePoints());
        }
        if(totalRisk <= 0)
        {
            totalPoints = pointGotten;
            doneCalculatePoint = true;
        }
        else if(totalRisk > 0)
        {
            totalPoints = pointGotten * totalRisk;
            doneCalculateRisk = true;
        }
    }
}
