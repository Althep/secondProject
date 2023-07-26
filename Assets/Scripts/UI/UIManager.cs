using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region UIs
    GameObject leftTopObj;
    GameObject rightTopObj;
    GameObject middleTopObj;
    GameObject leftMiddleObj;
    GameObject rightMiddleObj;
    GameObject leftBottomObj;
    GameObject middleBottomObj;
    GameObject rightBottomObj;
    GameObject uiPanel;
    #endregion
    GameObject calendar;
    GameObject dayScroll;

    ScrollRect dayScrollRect;
    void Start()
    {
        GetEdgeObjects();
        dayScrollRect.onValueChanged.AddListener(ClampScrollValue);
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
        calendar = uiPanel.transform.GetChild(8).gameObject;
        dayScroll = calendar.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject;
        dayScrollRect = calendar.transform.GetChild(2).transform.GetComponent<ScrollRect>();
    }
    public void CalendarButton()
    {
        if (calendar.activeSelf)
        {
            calendar.SetActive(false);
        }
        else
        {
            calendar.SetActive(true);
        }
    }
    public void ClampScrollValue(Vector2 value)
    {
        float clampedValue = Mathf.Clamp(value.y, 0f, 1f);
        dayScrollRect.verticalNormalizedPosition = clampedValue;
        
    }



}
