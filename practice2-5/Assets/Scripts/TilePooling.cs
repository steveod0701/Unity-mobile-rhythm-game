using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePooling : MonoBehaviour
{
    public static TilePooling current;
    public GameObject pooledTile;
    public int pooledAmount = 14;
    public bool willGrow = true;

    List<GameObject> pooledObjects;

    private void Start()
    {
        current = this;
        pooledObjects = new List<GameObject>();

        for (int i=0; i< pooledAmount; i++)
        {
            GameObject obj = Instantiate(pooledTile);
            obj.SetActive(false);
            pooledObjects.Add(obj);


        }

    }

    public GameObject GetPooledObject()
    {
        for(int i=0; i<pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];

            }

        }
        if (willGrow)
        {
            GameObject obj = Instantiate(pooledTile);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;

    }



}
