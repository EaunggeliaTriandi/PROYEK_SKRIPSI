using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeClockAndDate : MonoBehaviour
{
    public Text[] UITimeText;
    public Text[] UIDateText;

    public FormatTime timeFormat = FormatTime.Hour_24;
    //public FormatDate dateFormat = FormatDate.DD_MM_YYYY;

    public float minutePerSecond = 1;

    string _time;
    string _date;
    string setDaysName;

    int hours;
    int minute;

    int day;
    //int month;
    //int year;

    int maxHours;
    int maxMinute;

    //int maxDay;
    //int maxMonth;

    float timer;

    public enum FormatTime
    {
        Hour_24,
        Hour_12
    }
    //public enum FormatDate
    //{
    //    MM_DD_YYYY,
    //    DD_MM_YYYY,
    //    YYYY_MM_DD,
    //    YYYY_DD_MM

    //}

    // Update is called once per frame
    void Update()
    {
        if (timer >= minutePerSecond)
        {
            minute++;
            if (minute >= maxMinute)
            {
                minute = 0;
                hours++;
                if (hours >= maxHours)
                {
                    hours = 0;
                    day++;

                }
            }
        }
    }
}
