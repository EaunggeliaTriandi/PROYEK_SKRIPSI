using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] UnityEvent[] scriptCondition;
    public TimeDateManagement TDM;
    public GameObject pauseMenuPanels;
    public GameObject SettingPanels;
    public GameObject TutorialPanels;

    //public bool pauseMenuIsActive = false;
    //Pause Menu
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            callPauseMenu();
            //pauseMenuIsActive = true;
        }
        //if (Input.GetKeyDown(KeyCode.Escape) && pauseMenuIsActive)
        //{
        //    closePauseMenu();
        //    pauseMenuIsActive = false;
        //}

    }

    public void openSettingPanels()
    {
        SettingPanels.SetActive(true);
    }
    public void openTutorial()
    {
        TutorialPanels.SetActive(true);
    }
    public void closeTutorial()
    {
        TutorialPanels.SetActive(false);
    }
    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void closePauseMenu()
    {
        pauseMenuPanels.SetActive(false);
        callConditionInvoke(1);
        TDM.timeActive = true;
        SettingPanels.SetActive(false);
    }
    void callConditionInvoke(int onOrOff)
    {
        scriptCondition[onOrOff].Invoke();
    }
    void callPauseMenu()
    {
        pauseMenuPanels.SetActive(true);
        callConditionInvoke(0);
        TDM.timeActive = false;

    }

}
