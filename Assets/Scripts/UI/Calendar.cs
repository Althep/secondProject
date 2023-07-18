using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calendar : MonoBehaviour
{
    public int startDOW;// startWeek of Day 0=sunday
    public int endDay;
    public int month;
    public int year;
    public int dayOfYear;
    public int goneDay;

    public GameObject dayPrefab;
    GameObject calendar;
    GameObject calendarContent;
    Sprite[] daySprites;
    Sprite[] montheImages;
    Image monthImage;
    void Start()
    {
        calendar = GameObject.Find("Canvas").transform.GetChild(0).transform.GetChild(8).gameObject;
        calendarContent = calendar.transform.GetChild(2).transform.GetChild(0).transform.GetChild(0).gameObject;
        year = 1;
        startDOW = 6;
        month = 12;
        daySprites = Resources.LoadAll<Sprite>("Images\\Days\\Days");
        montheImages = Resources.LoadAll<Sprite>("Images\\Months");
        Debug.Log(montheImages.Length);
        CheckEndDay(month);
        FillCalendar(startDOW,endDay);
        monthImage = calendar.transform.GetChild(0).transform.GetChild(0).transform.GetComponent<Image>();
        ChangeMonthImage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMonthImage()
    {
        monthImage.sprite = montheImages[month-1];
        Debug.Log(Resources.Load<Sprite>("Images\\Months_" + month));
    }
    public void CheckEndDay(int m)
    {
        switch (m)
        {
            case 1:
                endDay = 31;
                break;
            case 2:
                if (year % 4 == 0)
                {
                    endDay = 29;
                }
                else
                {
                    endDay = 28;
                }
                break;
            case 3:
                endDay = 31;
                break;
            case 4:
                endDay = 30;
                break;
            case 5:
                endDay = 31;
                break;
            case 6:
                endDay = 30;
                break;
            case 7:
                endDay = 31;
                break;
            case 8:
                endDay = 31;
                break;
            case 9:
                endDay = 30;
                break;
            case 10:
                endDay = 31;
                break;
            case 11:
                endDay = 30;
                break;
            case 12:
                endDay = 31;
                break;
            default:
                Debug.Log("monthErorr!");
                break;
        }
    }
    public void FillCalendar(int dos, int days)
    {
        
        for (int i = 0; i < dos + days; i++)
        {
            GameObject go = Instantiate(dayPrefab);
            if (i < dos)
            {
                go.transform.GetComponent<Image>().sprite = daySprites[31];

            }
            else
            {
                if (i % 7 == 0)
                {
                    go.transform.GetComponent<Image>().sprite = daySprites[i + 33-dos];
                }
                else if (i % 7 == 6)
                {
                    go.transform.GetComponent<Image>().sprite = daySprites[i + 66 - dos];
                }
                else
                {
                    go.transform.GetComponent<Image>().sprite = daySprites[i - dos];
                }
            }
            go.transform.SetParent(calendarContent.transform);
            go.transform.localScale = new Vector3(1,1,1);
        }
    }
}
