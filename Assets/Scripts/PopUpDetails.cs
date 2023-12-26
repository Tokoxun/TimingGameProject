using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpDetails : MonoBehaviour
{
    public DetailsColorSwitch clrSwtch;
    public RectTransform uiElement; // Reference to the UI element you want to move
    public float moveSpeed = 80f; // Distance to move the UI upwards
    public float moveDistanceUp;
    public float moveDistanceDown;

    private bool isMoving = false;
    private bool Up = false;
    private bool Down = true;

    void Update()
    {
        if (isMoving && Down)
        {
            // Move the UI upwards
            Vector3 newPosition = uiElement.anchoredPosition;
            newPosition.y += moveSpeed * Time.deltaTime; // Move by distance over time
            uiElement.anchoredPosition = newPosition;

            // Check if reached the desired position
            if (newPosition.y >= moveDistanceUp)
            {
                isMoving = false;
                Down = false;
                Up = true;
            }
        }
        if(isMoving && Up)
        {
            // Move the UI downwards
            Vector3 newPosition = uiElement.anchoredPosition;
            newPosition.y -= moveSpeed * Time.deltaTime; // Move by distance over time
            uiElement.anchoredPosition = newPosition;

            // Check if reached the desired position
            if (newPosition.y <= moveDistanceDown)
            {
                isMoving = false;
                Up = false;
                Down = true;
            }
        }
    }

    public void MoveUIUp()
    {
        clrSwtch.ChangeSourceImage();
        // Triggered when the button is pressed
        isMoving = true;
    }
}
