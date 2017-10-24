using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchPanelButton : MonoBehaviour
{
    public BoxCollider goodPanel;
    public BoxCollider perfectPanel;

    public BoxCollider holdOnPanel;

    public void ActivePanelCollider()
    {
        
    }

    public void HoldOnActive()
    {
        InvokeEnable();
        Invoke("InvokeDisable", .15f);
        holdOnPanel.enabled = true;
    }

    public void HoldOnDeactive()
    {
        holdOnPanel.enabled = false;
    }

    public void InvokeEnable()
    {
        perfectPanel.enabled = true;
        goodPanel.enabled = true;
        

        
    }

    public void InvokeDisable()
    {

        perfectPanel.enabled = false;
        goodPanel.enabled = false;
        
    }
}

