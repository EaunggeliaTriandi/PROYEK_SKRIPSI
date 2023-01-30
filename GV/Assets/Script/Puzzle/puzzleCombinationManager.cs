using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puzzleCombinationManager : MonoBehaviour
{
    public Quest quest;
    public QuestGiver QG;
    public Player player;
    public PillarManager PM;
    public DebuggerUI debuggers;
    public FaddingUI fadding;
    public int timeForPuzzleQuest;
    public string PCMQuestNames;
    public string answer;
    public static string combination = "0000";
    // Start is called before the first frame update
    private void Update()
    {
        EnterCombination();
    }
    public void playerAnswer(int number)
    {
        answer += number.ToString();
    }
    public void EnterCombination()
    {

        if (answer.Length >= 4)
        {
            CheckAnswer();
            answer = "";
            StartCoroutine(PM.PillarReset());

        }
    }
    public void CheckAnswer()
    {
        if (quest.questIsActive & quest.questName == PCMQuestNames)
        {
            if (answer == combination)
            {
                Debug.Log("correct");

                Debug.Log("pillar masuk");
                quest.goal.puzzleSolved();
                if (quest.goal.IsReached())
                {
                    fadding.callFadding();
                    TimeDateManagement.hours += timeForPuzzleQuest;
                    TimeDateManagement.tempTime += timeForPuzzleQuest;
                    player.PlayerExperincePoint += quest.experienceReward;
                    player.PlayerGold += quest.goldReward;
                    debuggers.DebugText.text = quest.questTitle + " Is Completed!";
                    debuggers.DebugPanels.SetActive(true);
                    quest.Complete();
                    Player.PlayerEnergy -= 45;
                    QG.AcceptButton.interactable = true;
                    //objectToCollision = "haha";
                }
            }
            else
            {
                Debug.Log("false");
                fadding.callFadding();
                Player.PlayerHp -= 25;
            }

        }
        else
        {
            Debug.LogError("Quest Is Not Active");
        }

    }

}
