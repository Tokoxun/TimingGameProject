using UnityEngine;
using UnityEngine.UI;

public class InfoTag : MonoBehaviour
{
    public tagType currentType;
    public string tagName;
    public Image baseImage;
    public DetailsTag[] details;
    public int detailLevel;
}

public enum tagType {Permanent, Temporary};