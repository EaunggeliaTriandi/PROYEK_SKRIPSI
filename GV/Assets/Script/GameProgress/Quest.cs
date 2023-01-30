using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Quest
{
    public string questName;

    public bool ActiveQuest;

    public bool questIsActive;

    public bool questIsComplete;

    public string questTitle;
    public string questDescription;
    public int experienceReward;
    public int goldReward;


    public QuestGoal goal;

    public void Complete()
    {
        questIsActive = false;
        questIsComplete = true;
        ActiveQuest = false;
        questName = "";
        Debug.Log(questTitle + " was Completed!");
        goal.currentAmount = 0;
    }
}
