using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verdict2 : MonoBehaviour
{
    public GameObject missBlock;
    public GameObject marker;
    public GameObject player;
//    public ParticleSystem destroyEffect;
  //  private ParticleSystem destroyEffectInstance;

    private bool triggerFlag = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == missBlock)
        {
            Singletons.miss++;
            Debug.Log("miss");
            Combo.ComboVerdict(false);
            Destroy(marker);
    //        destroyEffectInstance = Instantiate(destroyEffect, transform.position, destroyEffect.transform.rotation);
      //      Destroy(destroyEffectInstance.gameObject, destroyEffectInstance.duration);
        }
    }

    void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(KeyCode.S)&&(triggerFlag))
        {
            triggerFlag = false;

            float distance;
            distance = marker.transform.position.x - player.transform.position.x;
            
            if (distance < 2.0)
            {
                Singletons.perfect++;
                Debug.Log("perfect");
                Combo.ComboVerdict(true);
            }
            else if ((distance >= 2.0) && (distance < 3.5))
            {
                Singletons.good++;
                Debug.Log("great");
                Combo.ComboVerdict(true);
            }
            else
            {
                Singletons.miss++;
                Debug.Log("miss");
                Combo.ComboVerdict(false);
            }
        //    destroyEffectInstance = Instantiate(destroyEffect, transform.position, destroyEffect.transform.rotation);
          //  Destroy(destroyEffectInstance.gameObject, destroyEffectInstance.duration);
            Destroy(marker);
        }
    }
}
