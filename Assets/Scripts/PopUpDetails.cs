using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpDetails : MonoBehaviour
{
    public CardScripts cardScripts;
    public GameObject detailsBox;
    public Text detailsText;
    private GameObject m_Blocker;
    public Canvas rootCanvas;

    public void ViewDetails()
    {
        if (detailsBox != null)
        {
            detailsBox.SetActive(true);
            m_Blocker = CreateBlocker(rootCanvas);
        }
    }

    public void HideDetails()
    {
        if (detailsBox != null)
        {
            detailsBox.SetActive(false);
            DestroyBlocker(m_Blocker);
        }
    }
    protected virtual GameObject CreateBlocker(Canvas rootCanvas)
    {
        // Create blocker GameObject.
        GameObject blocker = new GameObject("Blocker");

        // Set the game object layer to match the Canvas' game object layer, as not doing this can lead to issues
        // especially in XR applications like PolySpatial on VisionOS (UUM-62470).
        blocker.layer = rootCanvas.gameObject.layer;

        // Setup blocker RectTransform to cover entire root canvas area.
        RectTransform blockerRect = blocker.AddComponent<RectTransform>();
        blockerRect.SetParent(rootCanvas.transform, false);
        blockerRect.anchorMin = Vector3.zero;
        blockerRect.anchorMax = Vector3.one;
        blockerRect.sizeDelta = Vector2.zero;

        // Make blocker be in separate canvas in same layer as dropdown and in layer just below it.
        Canvas blockerCanvas = blocker.AddComponent<Canvas>();
        blockerCanvas.overrideSorting = true;
        blockerCanvas.sortingLayerID = rootCanvas.sortingLayerID;
        blockerCanvas.sortingOrder = 2;

        if (rootCanvas != null)
        {
            blocker.AddComponent(rootCanvas.GetComponent<GraphicRaycaster>().GetType());
        }

        // Add image since it's needed to block, but make it clear.
        Image blockerImage = blocker.AddComponent<Image>();
        blockerImage.color = Color.clear;

        // Add button since it's needed to block, and to close the dropdown when blocking area is clicked.
        Button blockerButton = blocker.AddComponent<Button>();
        blockerButton.onClick.AddListener(HideDetails);

        //add canvas group to ensure clicking outside the dropdown will hide it (UUM-33691)
        CanvasGroup blockerCanvasGroup = blocker.AddComponent<CanvasGroup>();
        blockerCanvasGroup.ignoreParentGroups = true;

        return blocker;
    }

    protected virtual void DestroyBlocker(GameObject blocker)
    {
        Destroy(blocker);
    }

    public void OnDisable()
        {
            if (m_Blocker != null)
            {
                DestroyBlocker(m_Blocker);
                m_Blocker = null;
            }
        }
}
