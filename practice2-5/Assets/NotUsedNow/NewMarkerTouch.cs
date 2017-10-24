using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMarkerTouch : MonoBehaviour
{
    public BoxCollider perfectZone;
    public BoxCollider greatZone;
    public GameObject player;


    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "perfectZone" && col.collider.name=="greatZone")
        {
            Singletons.perfect++;
            Debug.Log("perfect");
            Combo.ComboVerdict(true);

        }
        if (col.collider.name == "Player")
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
    }

}
