using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameObject leftTopObj;
    GameObject rightTopObj;
    GameObject middleTopObj;
    GameObject leftMiddleObj;
    GameObject rightMiddleObj;
    GameObject leftBottomObj;
    GameObject middleBottomObj;
    GameObject rightBottomObj;
    GameObject uiPanel;
    void Start()
    {
        GetEdgeObjects();
    }

    
    void Update()
    {
        
    }
    void GetEdgeObjects()
    {
        uiPanel = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        leftTopObj = uiPanel.transform.GetChild(0).gameObject;
        rightTopObj = uiPanel.transform.GetChild(1).gameObject;
        middleTopObj = uiPanel.transform.GetChild(2).gameObject;
        leftMiddleObj = uiPanel.transform.GetChild(3).gameObject;
        rightMiddleObj = uiPanel.transform.GetChild(4).gameObject;
        leftBottomObj = uiPanel.transform.GetChild(5).gameObject;
        rightBottomObj = uiPanel.transform.GetChild(6).gameObject;
        middleBottomObj = uiPanel.transform.GetChild(7).gameObject;
    }
}
