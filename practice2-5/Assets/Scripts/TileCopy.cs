using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileCopy : MonoBehaviour
{

    private int combo = 0;
    public GameObject tile;
    static public int updateNum = 0;
    private Vector3 tileVector = new Vector3(0, 0, 0);
    private GameObject copyTile;
    private GameObject player;
    private bool tileColor = false;
    


    public Sprite redNeon;
    public Sprite blueNeon;


    void TileColorChange()
    {
        //tile.gameObject.GetComponent<Image>().sprite = redNeon;
        //tile.GetComponent<Image>().sprite = redNeon;

        tile.GetComponent<Renderer>().material.color = Color.red;
        tile.transform.Find("Tile (1)").GetComponent<Renderer>().material.color = Color.red;
        tile.transform.Find("Tile (2)").GetComponent<Renderer>().material.color = Color.red;
    }

    void TileColorChange2()
    {
        //tile.gameObject.GetComponent<Image>().sprite = blueNeon;
        // tile.GetComponent<Image>().sprite = blueNeon;

        tile.GetComponent<Renderer>().material.color = Color.blue;
        tile.transform.Find("Tile (1)").GetComponent<Renderer>().material.color = Color.blue;
        tile.transform.Find("Tile (2)").GetComponent<Renderer>().material.color = Color.blue;
    }


    private void Start()
    {
        


        
    }
    
    void FixedUpdate()
        {
        if (true)
        {

//            if(updateNum % 60 == 0)
//            {
//
//            }

            if (updateNum % 60 == 0)
            {
                if (tileColor)
                {
                    TileColorChange();
                    tileColor = false;
                }
                else
                {
                    TileColorChange2();
                    tileColor = true;
                }
                copyTile = Instantiate(tile, tileVector, tile.transform.rotation);
                Destroy(copyTile,  5);
                tileVector += new Vector3(-20, 0, 0);

            }
            updateNum++;

        }
    }
    
        
    }


