using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckScript : MonoBehaviour
{
    public GameObject Position;

    public void DebugPosition()
    {
        Debug.Log(Position.transform.position);
    }


	
}
