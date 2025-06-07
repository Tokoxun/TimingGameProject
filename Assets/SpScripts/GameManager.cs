using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public delegate void gameOverItem();
    public gameOverItem gameOverEvent;
    public GameObject exitButton;
    public GameObject retryButton;
    public GameObject resultBoard;
    public PointSystem pointSystem;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI playerScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resultBoard.SetActive(false);
        playerScoreText.enabled = false;
    }
    public void GameOver()
    {
        gameOverEvent();
        resultBoard.SetActive(true);
        StartCoroutine(calculatePoints());
    }

    IEnumerator calculatePoints()
    {
        if (pointSystem != null)
        {
            if (pointSystem.points > PlayerPrefs.GetInt("SpPlayerHighScore", 0))
            {
                PlayerPrefs.SetInt("SpPlayerHighScore", pointSystem.points);
                playerScoreText.enabled = true;
                playerScoreText.text = pointSystem.points.ToString();
                yield return new WaitForSeconds(2f);
                highScoreText.text = PlayerPrefs.GetInt("SpPlayerHighScore", 0).ToString();
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
            else if (pointSystem.points <= PlayerPrefs.GetInt("SpPlayerHighScore", 0))
            {
                playerScoreText.enabled = true;
                playerScoreText.text = pointSystem.points.ToString();
                retryButton.SetActive(true);
                exitButton.SetActive(true);
            }
        }
        StopCoroutine(calculatePoints());
    }

    void OnDisable()
    {
        gameOverEvent = null;
    }

    public void ExitMode(string toMainMenu)
    {
        SceneManager.LoadScene(toMainMenu);
    }

    public void Retry(string currentScene)
    {
        SceneManager.LoadScene(currentScene);
    }
}
