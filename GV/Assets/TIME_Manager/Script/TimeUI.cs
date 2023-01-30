using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    [Header("Time Date Manager")]
    public TimeDateManagement TDM;
    [Space(10)]
    [Header("Days Management")]
    public DaysManagement DM;

    [Space(10)]
    [Header("Time Value")]
    public Text Minute;
    public Text Hour;
    public Text DaysNumber;
    public Text Days;

    // Update is called once per frame
    void Update()
    {
        Minute.text = TimeDateManagement.minute.ToString();
        Hour.text = TimeDateManagement.hours.ToString();
        DaysNumber.text = TimeDateManagement.day.ToString();
        Days.text = DM.callDays.ToString();
    }
}
