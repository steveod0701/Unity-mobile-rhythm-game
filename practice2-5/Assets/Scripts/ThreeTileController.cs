using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeTileController : MonoBehaviour
{
    public GameObject Player;
    

    private void OnEnable()
    {
        StartCoroutine("ThreeTileDisable");
    }

    /*private void Destroy()
    {
        gameObject.SetActive(false);
       

    }*/

    IEnumerator ThreeTileDisable()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            
            if (( gameObject.transform.position.x - Player.transform.position.x)>45)
            {
                gameObject.SetActive(false);
                
                
               

            }


        }

    }


  
  

    private void OnDisable()
    {

        StopCoroutine("ThreeTileDisable");

    }



}
