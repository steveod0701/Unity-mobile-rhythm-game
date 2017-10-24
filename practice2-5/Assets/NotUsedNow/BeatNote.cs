using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatNote : MonoBehaviour
{

    GameObject toFindHeart;
    //private float v = (float)(20.0 / 82) * -1;
    private float v = -0.333333333333333f;
    public GameObject beatNoteL;



    private void Awake()
    {
        GameObject heart = GameObject.Find("Heart");
        //BeatCheck beatCheck = heart.GetComponent<BeatCheck>();

        //toFindHeart = beatCheck.heart; 

        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(
    gameObject.GetComponent<RectTransform>().sizeDelta.x,
    gameObject.GetComponent<RectTransform>().sizeDelta.y
    );



    }



    // Update is called once per frame
    void FixedUpdate ()
    {
        //if (toFindHeart.transform.position.x < transform.position.x)
        {
            transform.Translate(-6, 0, 0);
        }

        if (!gameObject.active)
        {
            Destroy(beatNoteL);
        }
        


        
	}
}
