using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{

    public static Text textStatic;
    public Text textNonStatic;

    private void Start()
    {
        textStatic.text = Singletons.combo.ToString();
        textNonStatic.text = textStatic.text;
    }

    /*public static void ComboVerdict(bool c)
    {
        
        
        if (c)
        {
            Singletons.combo++;
        }
        else if (!c)
        {
            Singletons.combo = 0;
        }

        string comboNum = Singletons.combo.ToString();
        comboText.text = comboNum;

    }*/
    
    public static void ComboVerdict(bool combo)
    {
        if (combo)
        {
            Singletons.combo++;
        }
        else if (!combo)
        {
            Singletons.combo = 0;
        }
        //textStatic.text = Singletons.combo.ToString();
        //textNonStatic.text = textStatic.text;
    }
}
