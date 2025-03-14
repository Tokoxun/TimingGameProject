using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TagDrawerScript : MonoBehaviour, ICancelHandler
{
    public GameObject tagDrawer;
    public Slider drawerSlider;
    private bool display = false;
    private float slideSpeed;

    public void DrawerControl()
    {
        if(drawerSlider.value != drawerSlider.maxValue)
        {
            Show();
        }
        if(drawerSlider.value == drawerSlider.maxValue)
        {
            Hide();
        }
    }
    public void Show()
    {
        display = true;
        slideSpeed = 5f;
    }

    public void Hide()
    {
        display = false;
        slideSpeed = -5f;
    }

    public virtual void OnCancel(BaseEventData eventData)
    {
        Hide();
    }

    void Update()
    {
        if(slideSpeed != 0)
        {
            if(display)
            {
                drawerSlider.value += slideSpeed * Time.deltaTime;
                if(drawerSlider.value >= drawerSlider.maxValue)
                {
                    slideSpeed = 0;
                }
            }
            if(!display)
            {
                drawerSlider.value += slideSpeed * Time.deltaTime;
                if(drawerSlider.value <= drawerSlider.minValue)
                {
                    slideSpeed = 0;
                }
            }
        }
    }
}
