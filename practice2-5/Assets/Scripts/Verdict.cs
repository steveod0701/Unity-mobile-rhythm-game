using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verdict : MonoBehaviour
{ 
    //public GameObject marker;
    //public GameObject player;


    //public ParticleSystem destroyEffect;
    //private ParticleSystem destroyEffectInstance;
    //private float distance;
    //public float cantSeeDistance = 40f;


    //public GameObject componentA;
    //public GameObject componentB;
    //public HealthSlider healthSlider;
    

    
    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "PerfectCollider")
        {           
            Singletons.perfect++;
            Debug.Log("Perfect");
            //Combo.ComboVerdict(true);
           
            //healthSlider.RestoreHealthP();
            //healthSlider.SetHealthUI();
        }

        //distance = Mathf.Abs(marker.transform.position.x - player.transform.position.x);
        //if (distance < 2.0&& other.gameObject.tag != "PlayerLine")
        //if (check == 0)
        //{
        if (other.gameObject.tag == "GoodCollider")
        {
            Singletons.good++;
            Debug.Log("Good");
            //Combo.ComboVerdict(true);
            //healthSlider.RestoreHealthG();
            //healthSlider.SetHealthUI();
        }
        //}
        /*else if ((distance >= 2.0) && (distance < 3.5))
        {
            Singletons.great++;
            Debug.Log("great");
            Combo.ComboVerdict(true);
        }*/

        else if(other.gameObject.tag=="PlayerLine")
        {
            Singletons.miss++;
            Debug.Log("miss");
            Combo.ComboVerdict(false);
            //healthSlider.TakeDamage(15);
            //healthSlider.SetHealthUI();            
        }
        //    destroyEffectInstance = Instantiate(destroyEffect, transform.position, destroyEffect.transform.rotation);
        //  Destroy(destroyEffectInstance.gameObject, destroyEffectInstance.duration);
        Destroy(gameObject);
    }
}
    /*public void FixedUpdate()
    {
        distance = Mathf.Abs(marker.transform.position.x - player.transform.position.x);
        
  //      MarkerDisableWithDistance();
    //    MarkerEnableWithDistance();
        

        
    }*/
    /*
    private void MarkerEnableWithDistance()
    {
        

        if (distance < cantSeeDistance)
        {
            componentA.SetActive(true);
            componentB.SetActive(true);
        }
    }
    private void MarkerDisableWithDistance()
    {
        

        if (distance > cantSeeDistance)
        {
            //componentA.SetActive(false);
            componentB.SetActive(false);
        }
    }
*/


