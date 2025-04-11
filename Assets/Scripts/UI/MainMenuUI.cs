using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public string sceneName;
    public GameObject gameMenu;
    public void OpenGameMenu()
    {
        gameMenu.SetActive(true);
    }
    public void LoadGame()
    {
        if(sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void CancelMenu()
    {
        gameMenu.SetActive(false);
    }
    public void OpenOptions()
    {}
    public void QuitGame()
    {
        Application.Quit();
    }
}
