using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebuggerUI : MonoBehaviour
{
    public GameObject DebugPanels;
    public Text DebugText;

    public void closeDebugger()
    {
        DebugPanels.SetActive(false);
    }
}


