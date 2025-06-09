using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
	public InputAction pauseButton;
    public GameObject pauseObjects;
	public GameObject startingTag;
	public UnityEvent gameOverEvent;

	// Use this for initialization
	void Start () 
	{
		startingTag.SetActive(true);
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
	}

	//controls the pausing of the scene
	public void pauseControl(){
			if(Time.timeScale == 1 && DifficultyManager.disablePause == false)
			{
				Time.timeScale = 0;
				showPaused();
			} 
            else if (Time.timeScale == 0){
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
	public void TriggerGameOver()
	{
		gameOverEvent.Invoke();
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
