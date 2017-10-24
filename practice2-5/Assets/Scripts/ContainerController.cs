using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerController : MonoBehaviour
{
    public GameObject player;
    //private float v = (float)(20.0 / 82) * -1;
    private float v = 0.333333f;
    private void FixedUpdate()
    {
        player.transform.position += new Vector3(-v, 0, 0);
    }


}
