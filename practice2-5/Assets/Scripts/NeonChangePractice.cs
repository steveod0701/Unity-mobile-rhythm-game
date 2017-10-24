using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeonChangePractice : MonoBehaviour
{
    public Sprite blueNeon;
    public Sprite greenNeon;
    private bool isBlue = true;
    

    void TileColorChange()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = blueNeon;


        //tile.gameObject.GetComponent<Image>().sprite = redNeon;
        //tile.GetComponent<Image>().sprite = redNeon;

        /*tile.GetComponent<Renderer>().material.color = Color.red;
        tile.transform.Find("Tile (1)").GetComponent<Renderer>().material.color = Color.red;
        tile.transform.Find("Tile (2)").GetComponent<Renderer>().material.color = Color.red;*/
    }

    void TileColorChange2()
    {

        gameObject.GetComponent<SpriteRenderer>().sprite = greenNeon;


        //tile.gameObject.GetComponent<Image>().sprite = blueNeon;
        // tile.GetComponent<Image>().sprite = blueNeon;

        /*tile.GetComponent<Renderer>().material.color = Color.blue;
        tile.transform.Find("Tile (1)").GetComponent<Renderer>().material.color = Color.blue;
        tile.transform.Find("Tile (2)").GetComponent<Renderer>().material.color = Color.blue;*/
    }


    // Update is called once per frame
    /*void FixedUpdate ()
    {
        if(updateNum%120 == 60)
        {
            TileColorChange();
        }

        if(updateNum%120== 0)
        {
            TileColorChange2();
        }

        updateNum++;
	}*/

    private void OnEnable()
    {
        StartCoroutine("ColorChange");
    }

    private void OnDisable()
    {
        StopCoroutine("ColorChange");
    }

    IEnumerator ColorChange()
    {
        while (true)
        {
            yield return new WaitForSeconds(.7f);
            if (isBlue)
            {
                TileColorChange2();
                isBlue = false;
            }
            else if (!isBlue)
            {
                TileColorChange();
                isBlue = true;
                
            }
        }
    }
}
