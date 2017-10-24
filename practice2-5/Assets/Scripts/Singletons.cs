using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singletons : MonoBehaviour
{
    public static int perfect = 0;
    public static int good = 0;
    public static int miss = 0;
    public static int combo = 0;
    public static int xOfTiles = 0;
    public static float musicVolume = 1f;

    public static int bestScore = 0;

    public static GameObject missBlock;

    private void Awake()
    {
        missBlock = GameObject.Find("MissCheck");
    }

    private int currentCombo;
    public Text comboText;

    private void Start()
    {
        currentCombo = 0;
    }
    public void SetComboText()
    {
        currentCombo = combo;
        comboText.text = currentCombo.ToString();
    }
}
