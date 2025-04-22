using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Text normalHighScore;
    public Text normalDisturbanceScore;
    public GameObject normalClearScore;
    public Text tradiHighScore;
    public string sceneName;
    public GameObject gameMenu;
    public GameObject optionMenu;
    void Start()
    {
        gameMenu.SetActive(false);
        optionMenu.SetActive(false);
    }
    void Update()
    {
        if(normalHighScore != null && normalDisturbanceScore != null)
        {
            normalHighScore.text = PlayerPrefs.GetInt("playerHighScore").ToString();
            normalDisturbanceScore.text = PlayerPrefs.GetInt("playerHighestRisk").ToString();
        }
        if(PlayerPrefs.GetInt("playerHighScore", 0) <= 0 && PlayerPrefs.GetInt("playerHighestRisk", 0) <= 0)
        {
            normalClearScore.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("playerHighScore", 0) > 0 || PlayerPrefs.GetInt("playerHighestRisk", 0) > 0)
        {
            normalClearScore.SetActive(true);
        }
    }
    public void OpenGameMenu()
    {
        gameMenu.SetActive(true);
    }
    public void OpenOptionMenu(OptionsScript options)
    {
        options.soundEffectSlider.value = AudioManager.SEsetting;
        options.displayOptions.value = OptionsScript.currentDisplay;
        optionMenu.SetActive(true);
    }
    public void ClearHighScore(string highScoreName)
    {
        if(PlayerPrefs.HasKey(highScoreName))
        {
            PlayerPrefs.SetInt(highScoreName, 0);
        }
    }
    public void LoadGame()
    {
        if(sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void CancelMenu(GameObject menuUI)
    {
        menuUI.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
