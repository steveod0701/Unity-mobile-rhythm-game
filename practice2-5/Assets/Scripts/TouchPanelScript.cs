using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPanelScript : MonoBehaviour
{
    /*private GameObject note;
    public bool active;
    public TouchPanelJudgeScript judgeScript;

    private void Awake()
    {
        judgeScript = GetComponent<TouchPanelJudgeScript>();
        active = false;
        
    }

    private void OnTriggerEnter(Collider col)
    {
        note = col.gameObject;
        active = true;

    }

    private void OnMouseDown()
    {
        if (judgeScript.judgeActive && active) // perfect
        {

        }

            
        if (Physics.CheckBox(touchPanel.transform.position, touchPanel.transform.localScale, touchPanel.transform.rotation))
        {

        }
    }*/

    public BoxCollider touchPanelJudge;
    public BoxCollider touchPanel;

    private void Awake()
    {
        
    }

    private void OnMouseDown()
    {
        touchPanelJudge.enabled = true;
        //if (touchPanelJudge.enabled==true)
            
        {
            
            Debug.Log("Babo");
        }

        
    }

    private void OnMouseUp()
    {
        touchPanelJudge.enabled = false;
        Debug.Log("is you");
    }
}
