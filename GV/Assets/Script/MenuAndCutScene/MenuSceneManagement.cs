using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManagement : MonoBehaviour
{
    public GameObject TutorialPanels;
    public GameObject CreditPanels;

    //Tutorial Panels
    public void openTutorialPanel()
    {
        TutorialPanels.SetActive(true);
    }
    public void closeTutorialPanel()
    {
        TutorialPanels.SetActive(false);
    }

    public void openCreditPanel()
    {
        CreditPanels.SetActive(true);
    }
    public void closeCreditPanel()
    {
        CreditPanels.SetActive(false);
    }


    //Scene
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ContinueGame()
    {
        
    }
    public void quitAplication()
    {
        Application.Quit();
    }
}
