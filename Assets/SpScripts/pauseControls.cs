using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class pauseControls : MonoBehaviour
{
    public InputAction pauseButton;
    public GameObject pauseObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseButton.Enable();
        Time.timeScale = 1;
        hidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        //uses the p button to pause and unpause the game
        if (pauseButton.triggered)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }

    public void pauseControl()
    {
        if (Time.timeScale == 1 && DifficultyManager.disablePause == false)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        pauseObjects.SetActive(true);
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        pauseObjects.SetActive(false);
    }

    //loads inputted level
    // public void LoadLevel(string level)
    // {
    // 	SceneManager.LoadScene(level);
    // }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
