using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public static int PlayerHp = 100;
    public static int PlayerEnergy = 100;

    public int PlayerGold = 5;
    public int PlayerExperincePoint = 0;

    public int areaExploringTime;
    public string questNames;
    public string nameOfArea;
    public Quest quest;

    public QuestGiver QG;
    public DebuggerUI debugger;
    public FaddingUI fadding;

    //Exploration
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (quest.questIsActive & quest.questName == questNames)
        {
            if (collision.gameObject.name == nameOfArea)
            {
                Debug.Log("masukArea");
                quest.goal.areaExplored();
                if (quest.goal.IsReached())
                {
                    fadding.callFadding();
                    TimeDateManagement.hours += areaExploringTime;
                    TimeDateManagement.tempTime += areaExploringTime;
                    PlayerExperincePoint += quest.experienceReward;
                    PlayerGold += quest.goldReward;
                    debugger.DebugText.text = quest.questTitle + " Is Completed!";
                    debugger.DebugPanels.SetActive(true);
                    quest.Complete();
                    PlayerEnergy -= 45;
                    QG.AcceptButton.interactable = true;
                    //objectToCollision = "haha";
                }
            }

        }
    }

}
