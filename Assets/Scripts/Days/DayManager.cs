using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    public SpecialDay birthDay;




    public void GetBirthDay(int month, int day)
    {
        birthDay.month = month;
        birthDay.day = day;
    }

}
