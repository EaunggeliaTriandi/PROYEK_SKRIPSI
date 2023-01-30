using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public bool timeActive;
    public float changeTime;
    public int SceneNumber;

    private void Start()
    {
        timeActive = true;   
    }
    void Update()
    {
        if (timeActive)
        {
            changeTime -= Time.deltaTime;
            if (changeTime <= 0)
            {
                SceneManager.LoadScene(SceneNumber);
            }
        }
    }
}
