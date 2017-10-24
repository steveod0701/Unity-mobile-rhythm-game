using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledTileGenerator : MonoBehaviour
{
    public float tileTime = .7f;
    public GameObject player;

    private Vector3 tileVector = new Vector3(0, 0, 0);

    private void Start()
    {
        InvokeRepeating("ThreeTileCopy", tileTime, tileTime);
    }



    private void ThreeTileCopy()
    {
        GameObject obj = TilePooling.current.GetPooledObject();

        if (obj == null)
            return;

        obj.transform.position = tileVector;
        obj.transform.rotation = transform.rotation;
        obj.SetActive(true);

        tileVector += new Vector3(-20, 0, 0);
        Singletons.xOfTiles -= 20;
        if(Mathf.Abs(obj.transform.position.x - player.transform.position.x) > 150)
        {
            obj.SetActive(false);

            tileVector += new Vector3(20, 0, 0);

        }
    }
	
}
