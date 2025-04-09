using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InfoTag : MonoBehaviour
{
    public tagType currentType;
    public int rNumber;
    public Image baseImage;
    public Sprite Level_I;
    public Sprite Level_II;
    public Sprite Level_III;
    public string Description;
}

public enum tagType {Permanent, Temporary};