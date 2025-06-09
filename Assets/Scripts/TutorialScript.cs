using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorialBackground;
    public GameObject[] pageIndicate;
    public GameObject[] pages;
    private int currentPage;
    public Button rightArrow;
    public Button leftArrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPage = 0;
        tutorialBackground.SetActive(false);
    }

    void Update()
    {
        if (currentPage < 0)
        {
            currentPage = pages.Length - 1;
        }
        else if (currentPage > pages.Length - 1)
        {
            currentPage = 0;
        }
        for (int i = 0; i < pages.Length; i++)
        {
            if (i != currentPage)
            {
                pageIndicate[i].SetActive(false);
                pages[i].SetActive(false);
            }
            else if (i == currentPage)
            {
                pageIndicate[i].SetActive(true);
                pages[i].SetActive(true);
            }
        }
    }

    public void nextPage()
    {
        currentPage += 1;
    }

    public void backPage()
    {
        currentPage -= 1;
    }

    public void closeTutorial()
    {
        tutorialBackground.SetActive(false);
    }

    public void openTutorial()
    {
        tutorialBackground.SetActive(true);
    }
}
