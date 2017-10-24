using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderParticleEffect : MonoBehaviour
{
    public GameObject destroyEffect;
    private GameObject destroyEffectInstantiate;
    private HealthSlider healthSlider;
    private Text comboText;

    private void Start()
    {
        healthSlider = GameObject.Find("HealthSlider").GetComponent<HealthSlider>();
        comboText = GameObject.Find("ComboText").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Note")
        {
            destroyEffectInstantiate = Instantiate(destroyEffect, transform.position, destroyEffect.transform.rotation);
            Destroy(destroyEffectInstantiate.gameObject, 3f);
            //healthSlider.RestoreHealthP();
            healthSlider.RestoreHealthP();
            Singletons.combo++;
            comboText.text = Singletons.combo.ToString();
            
               
        }

    }
}
