using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject resultScreen;
    public PointSystem calPoint;
    public TagInventory tagRNum;
    private int pointGotten;
    private int totalRisk;
    private int totalPoints;
    public Text pointText;
    public Text riskText;
    public Text totalPointsText;
    public Text highScoreText;
    private bool doneCalculatePoint;
    private bool doneCalculateRisk;
    public GameObject resetBar;

    void Start()
    {
        isGameOver = false;
        resetBar.SetActive(false);
        resultScreen.SetActive(false);
        doneCalculatePoint = false;
        doneCalculateRisk = false;
        highScoreText.text = PlayerPrefs.GetInt("playerHighScore", 0).ToString();
    }
    public void DisplayResult()
    {
        isGameOver = true;
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
            else if(calPoint.points <= 0 && !doneCalculatePoint)
            {
                pointGotten = calPoint.points;
                doneCalculatePoint = true;
            }
            if(tagRNum.selectedTags.Count > 0 && !doneCalculateRisk)
            {
                foreach(TagSlotScript r in tagRNum.tagSlot)
                {
                    totalRisk += r.recordedRNum;
                }
                totalPoints = pointGotten * totalRisk;
                doneCalculateRisk = true;
            }
            else if(tagRNum.selectedTags.Count <= 0 && !doneCalculateRisk)
            {
                totalRisk = 0;
                totalPoints = pointGotten;
                doneCalculateRisk = true;
            }
        }
        if(doneCalculatePoint && doneCalculateRisk)
        {
            pointText.text = pointGotten.ToString();
            yield return new WaitForSeconds(2f);
            riskText.text = totalRisk.ToString();
            if(totalRisk > PlayerPrefs.GetInt("playerHighestRisk", 0))
            {
                PlayerPrefs.SetInt("playerHighestRisk", totalRisk);
            }
            if(totalPoints > PlayerPrefs.GetInt("playerHighScore", 0))
            {
                yield return new WaitForSeconds(4f);
                totalPointsText.text = totalPoints.ToString();
                PlayerPrefs.SetInt("playerHighScore", totalPoints);
                resetBar.SetActive(true);
                StopCoroutine(CalculatePoints());
            }
            else if(totalPoints < PlayerPrefs.GetInt("playerHighScore", 0))
            {
                yield return new WaitForSeconds(2f);
                totalPointsText.text = totalPoints.ToString();
                resetBar.SetActive(true);
                StopCoroutine(CalculatePoints());
            }
        }
    }
}