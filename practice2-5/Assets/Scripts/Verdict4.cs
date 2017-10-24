using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verdict4 : MonoBehaviour
{
    
    private int holdNum=0;
    
    public Text comboText;
    

    private GameObject missBlock;

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MissBlock")
        {
            //Debug.Log("miss");
            //Combo.ComboVerdict(false);
            Destroy(marker);
            healthSlider.TakeDamage(15);
        }
    }*/

    private void Start()
    {
        missBlock = Singletons.missBlock;
    }

    void OnTriggerStay(Collider col)
    {
        holdNum++;

        if (holdNum % 8 == 0)
        {
            if (col.gameObject.tag == "HoldOnCollider")
            {
                //Singletons.perfect++;
                //Debug.Log("perfect");
                //Combo.ComboVerdict(true);
                Singletons.combo++;
                //Singletons.SetComboText();
                comboText.text = Singletons.combo.ToString();

                missBlock.SetActive(false);
                Invoke("MissBlockActive", 0.8f);


            }
        }
    }



    private void MissBlockActive()
    {
        missBlock.SetActive(true);
    }
}
