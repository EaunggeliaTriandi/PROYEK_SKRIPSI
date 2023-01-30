using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeDateManagement : MonoBehaviour
{
    public Quest quest;
    public AudioClipController AuClipControl;
    public DebuggerUI debbuger;
    public FaddingUI fadding;
    [SerializeField]
    UnityEvent[] m_takeEvent;
    [Space(10)]
    [Header("Time Settings")]
    public float minutePerSecond = 1;

    
    public static int hours = 6;
    public static int minute;

    public static int day;


    public int maxHours = 24;
    public int maxMinute = 60;

    public bool DayTime;
    public static int tempTime;
    public bool sleepTime;

    public float timer;

    public bool timeActive = false;

    public bool stayUplate= false;


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    hours += 4;
        //    tempTime += 4;
        //}
        if (timeActive == true)
        {
            timer += Time.deltaTime;
            if (timer >= minutePerSecond)
            {
                minute++;
                if (minute >= maxMinute)
                {
                    minute = 0;
                    hours++;
                    tempTime++;


                    if (hours >= maxHours)
                    {
                        hours = 0;
                        day++;
                        DaysManagement.daysIndex += 1;

                    }
                }

                timer = 0;

            }
            if (tempTime >= 12 && DayTime)
            {
                Debug.Log("Siang");
                DayTime = false;
                
                
                onDayTime();
                tempTime = 0;

            }
            if (tempTime >=12 && !DayTime)
            {
                sleepTime = true;
                Debug.Log("malam");
                DayTime = true;
                stayUplate = true;
                onNightTime();
                tempTime = 0;
            }
            if (hours >= 23 && stayUplate)
            {
                notSleeping();
                stayUplate = false;
            }

        }
        onTimeCondition();



    }
    void onTimeCondition()
    {
    }
    public void onTimeChange(int HourArray)
    {
        m_takeEvent[HourArray].Invoke();
    }
    void onDayTime()
    {
        AuClipControl.DayBGM();
        fadding.callFadding();
        if (quest.ActiveQuest)
        {
            quest.questIsActive = true;
        }
        onTimeChange(0);
        
    }
    void onNightTime()
    {
        AuClipControl.NightBGM();
        fadding.callFadding();
        if (quest.ActiveQuest)
        {
            quest.questIsActive = false;
        }
        onTimeChange(1);
        onTimeChange(2);
        
    }
    public void sleep()
    {
        if (hours >= 18 && sleepTime)
        {
            fadding.callFadding();
            Player.PlayerEnergy = 100;
            AuClipControl.DayBGM();
            Debug.Log("siang");
            day += 1;
            DaysManagement.daysIndex+=1;
            hours = 6;
            sleepTime = false;
            DayTime = false;
            onDayTime();
            tempTime = 0;

        }
        else
        {
            Debug.Log("Can't sleep in day time");
            debbuger.DebugText.text = "Can't sleep during day time";
            debbuger.DebugPanels.SetActive(true);
        }
    }
    public void notSleeping()
    {
        AuClipControl.DayBGM();
        fadding.callFadding();
        Player.PlayerHp -= 50;
        day += 1;
        DaysManagement.daysIndex += 1;
        hours = 6;
        sleepTime = false;
        DayTime = false;
        onDayTime();
        tempTime = 0;
        if (Player.PlayerHp <= 0)
        {
            fadding.CallGameOver();
        }
    }
    public void TimeSkip()
    {
        fadding.callFadding();
        hours += 1;
        minute = 0;
        tempTime += 1;
    }

}

