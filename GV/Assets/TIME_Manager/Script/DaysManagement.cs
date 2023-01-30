using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaysManagement : MonoBehaviour
{
    public string[] daysName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public string callDays;

    public static int daysIndex = 0;


    private void Update()
    {
        //var execute = Input.GetKeyDown(KeyCode.Backspace);
        if (daysIndex == 0)
        {
            callDays = daysName[0];
        }
        if (daysIndex == 1)
        {
            callDays = daysName[1];
        }
        if (daysIndex == 2)
        {
            callDays = daysName[2];
        }
        if (daysIndex == 3)
        {
            callDays = daysName[3];
        }
        if (daysIndex == 4)
        {
            callDays = daysName[4];
        }
        if (daysIndex == 5)
        {
            callDays = daysName[5];
        }
        if (daysIndex == 6)
        {
            callDays = daysName[6];
        }
        if (daysIndex == 7)
        {
            callDays = daysName[0];
        }
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    daysIndex += 1;


        if (daysIndex >= 8)
        {
            daysIndex = 1;
        }
        //Debug.Log(daysIndex);
        //Debug.Log(callDays);
        //}


    }
}
