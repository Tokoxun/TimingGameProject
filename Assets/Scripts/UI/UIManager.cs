using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public InputAction pauseButton;
    public GameObject[] pauseObjects;


	// Use this for initialization
	void Start () 
	{
		pauseButton.ChangeBinding(0).WithPath("<Keyboard>/Escape");
		pauseButton.Enable();
		Time.timeScale = 1;
		// pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Update is called once per frame
	void Update () 
    {
		//uses the p button to pause and unpause the game
		if(pauseButton.triggered)
		{
			if(Time.timeScale == 1 && DifficultyManager.disablePause == false)
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
	public void showPaused(){
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(false);
		}
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
}
