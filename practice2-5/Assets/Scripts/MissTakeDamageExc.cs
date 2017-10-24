using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissTakeDamageExc : MonoBehaviour
{
    public Text comboText;
    public HealthSlider sliderControll;
    private void Start()
    {
        comboText.text = "0";
    }
    private void OnTriggerEnter(Collider other)
    {   
        {
            Singletons.combo = 0;
            comboText.text = "0";
            sliderControll.TakeDamage(15);
        }
    }

}
