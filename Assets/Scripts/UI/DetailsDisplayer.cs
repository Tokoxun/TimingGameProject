using TMPro;
using UnityEngine;

public class DetailsDisplayer : MonoBehaviour
{
    public TextMeshProUGUI detailName;
    public TextMeshProUGUI detailTemplate;

    public void UpdateDetail(string detailDescription, string name)
    {
        detailName.text = name;
        detailTemplate.text = detailDescription;
    }
}
