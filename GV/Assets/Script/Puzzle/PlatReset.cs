using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatReset : MonoBehaviour
{
    
    private PillarManager PM;

    private void Start()
    {
        
        PM = GameObject.FindGameObjectWithTag("PM").GetComponent<PillarManager>();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    PM.callReset();

    //}
    public void getAction()
    {
        PM.callReset();
    }
}
