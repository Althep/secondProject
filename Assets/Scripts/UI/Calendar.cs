using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialDay
{
    public int month;
    public int day;
}
public class Calendar : MonoBehaviour
{
    public int startDOW;// startWeek of Day 0=sunday
    public int endDay;
    public int month;
    public int year=1;
    public int dayOfYear;
    public int goneDay;
    public int dayTotal;
    public int nowDay;

    public GameObject dayPrefab;
    GameObject calendar;
    GameObject calendarContent;
    Sprite[] daySprites;
    Sprite[] montheImages;
    Image monthImage;
    DayManager dayManager;
    void Start()
    {
        //calendar = GameObject.Find("Canvas").transform.GetChild(0).transform.GetChild(8).gameObject;
        //calendarContent = calendar.transform.GetChild(2).transform.GetChild(0).transform.GetChild(0).gameObject;
        //daySprites = Resources.LoadAll<Sprite>("Images\\Days\\Days");
        //montheImages = Resources.LoadAll<Sprite>("Images\\Months");
        //month = 1;
        //CheckEndDay(month);
        //FillCalendar(startDOW, endDay);
        //monthImage = calendar.transform.GetChild(0).transform.GetChild(0).transform.GetComponent<Image>();
        //ChangeMonthImage();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeMonthImage()
    {
        monthImage.sprite = montheImages[month - 1];
    }
    public int CheckEndDay(int m)
    {
        switch (m)
        {
            case 1:
                endDay = 31;
                return endDay;
            case 2:
                if (year % 4 == 0)
                {
                    endDay = 29;
                    return endDay;
                }
                else
                {
                    endDay = 28;
                    return endDay;
                }
            case 3:
                endDay = 31;
                return endDay;
            case 4:
                endDay = 30;
                return endDay;
            case 5:
                endDay = 31;
                return endDay;
            case 6:
                endDay = 30;
                return endDay;
            case 7:
                endDay = 31;
                return endDay;
            case 8:
                endDay = 31;
                return endDay;
            case 9:
                endDay = 30;
                return endDay;
            case 10:
                endDay = 31;
                return endDay;
            case 11:
                endDay = 30;
                return endDay;
            case 12:
                endDay = 31;
                return endDay;
            default:
                Debug.Log("monthErorr!");
                return 0;
        }
    }
    public void FillCalendar(int dos, int days)
    {

        for (int i = 0; i < dos + days; i++)
        {
            GameObject go = Instantiate(dayPrefab);
            if (i < dos)
            {
                go.transform.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);

            }
            else
            {
                if (i % 7 == 0)
                {
                    go.transform.GetChild(0).transform.GetComponent<Image>().sprite = daySprites[i + 31 - dos];
                }
                else if (i % 7 == 6)
                {
                    go.transform.GetChild(0).transform.GetComponent<Image>().sprite = daySprites[i + 62 - dos];
                }
                else
                {
                    go.transform.GetChild(0).transform.GetComponent<Image>().sprite = daySprites[i - dos];
                }
            }
            go.transform.SetParent(calendarContent.transform);
            go.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void ChangeYear()
    {
        while (dayTotal > 365)
        {
            if (year % 4 != 0)
            {
                this.dayTotal = -365;
                year++;
            }
            else
            {
                this.dayTotal -= 366;
                year++;
            }

        }
    }
    public void ChangeMonth()
    {

    }
    public void GetTotalDayFromBirthDay(SpecialDay birthDay)
    {
        dayTotal = 0;
        for (int i = 0; i < birthDay.month; i++)
        {
            dayTotal = dayTotal + CheckEndDay(i);
        }
        dayTotal += birthDay.day;
    }
    public void DateFromTotal(int dayTotal)
    {

    }


}
