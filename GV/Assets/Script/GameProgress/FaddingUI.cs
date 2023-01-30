using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FaddingUI : MonoBehaviour
{
    [SerializeField] UnityEvent[] m_CallScriptObject;
    public GameObject PaddingPanels;
    public GameObject GameOverPanels;
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private bool fadeIn= false;
    [SerializeField] private bool fadeOut =false;
    private void Start()
    {
        callFadding();
    }

    public void ShowUI()
    {
        PaddingPanels.SetActive(true);
        fadeIn = true;
    }

    // Update is called once per frame
    public void HideUI()
    {
        fadeOut = true;

    }
    public void callFadding()
    {
        StartCoroutine(WaitForPadding());
    }
    IEnumerator WaitForPadding()
    {
        movementCondition(0);
        ShowUI();
        yield return new WaitForSeconds(2);
        HideUI();
    }
    void movementCondition(int eventList)
    {
        m_CallScriptObject[eventList].Invoke();
    }
    public void CallGameOver()
    {
        StartCoroutine(gameOverFadding());
        movementCondition(0);
    }
    IEnumerator gameOverFadding()
    {
        callFadding();
        yield return new WaitForSeconds(1);
        GameOverPanels.SetActive(true);
    }
    private void Update()
    {
        if (fadeIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
        if (fadeOut)
        {
            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                    PaddingPanels.SetActive(false);
                    movementCondition(1);
                }

            }
        }
    }
}
