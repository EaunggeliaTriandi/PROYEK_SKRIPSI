using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public DebuggerUI debugger;

    public Quest[] quest;

    public Quest currentQuest;

    public int currentQuestValue;
    //Using Quest Event
    public Player player;
    public puzzleCombinationManager PCM;
    public TimeDateManagement TDM;
    public BlocadeManager BM;

    public GameObject questWindow;

    public Text tittleText;
    public Text descriptionText;
    public Text goldText;
    public Text expText;

    public Button AcceptButton;


    [Header("Exploring Area")]
    public string OpenArea = "";
    public string NonAreaTrigger = "";
    public string objectToCollision = "Ruin1ExploreArea";
    public string objectToCollision1 = "SouthAshavananForest";
    public string objectToCollision2 = "AzhavanBeachArea";


    private void Start()
    {
        currentQuestValue = 0;
        currentQuest = quest[currentQuestValue];
    }
    public void OpenQuestWindows()
    {
        questWindow.SetActive(true);

        tittleText.text = currentQuest.questTitle;
        descriptionText.text = currentQuest.questDescription;
        goldText.text = currentQuest.goldReward.ToString();
        expText.text = currentQuest.experienceReward.ToString();


    }

    public void AcceptQuest()
    {
        if (Player.PlayerEnergy <= 30)
        {
            debugger.DebugPanels.SetActive(true);
            debugger.DebugText.text = "Not Enough Energy";
        }
        else
        {

            questWindow.SetActive(false);
            AcceptButton.interactable = false;
            quest[currentQuestValue].questIsActive = true;

            //Add New Type Puzzle
            player.quest = currentQuest;
            PCM.quest = currentQuest;
            TDM.quest = currentQuest;
            BM.quest = currentQuest;


            OpenArea = currentQuest.questTitle;
            player.questNames = currentQuest.questName;
            PCM.PCMQuestNames = currentQuest.questName;
            player.nameOfArea = OpenArea;
            puzzleCombinationManager.combination = currentQuest.goal.puzzleCombination;
            PCM.PCMQuestNames = currentQuest.questName;
        }


    }
    public void CloseQuest()
    {
        questWindow.SetActive(false);

    }

    public void OpenQuest()

    {
        if (TDM.DayTime == false)
        {

            if (!currentQuest.questIsActive)
            {
                for (int i = 0; i < quest.Length; i++)
                {
                    if (!quest[i].questIsComplete || currentQuest.ActiveQuest)
                    {
                        OpenQuestWindows();

                    }
                    else
                    {
                        if (currentQuestValue >= quest.Length - 1)
                        {
                            AcceptButton.interactable = false;
                            tittleText.text = "no quest available";
                        }
                        else
                        {

                            quest[currentQuestValue].ActiveQuest = false;
                            currentQuestValue += 1;
                            quest[currentQuestValue].ActiveQuest = true;

                            if (quest[currentQuestValue].ActiveQuest == true)
                            {
                                currentQuest = quest[currentQuestValue];
                                OpenQuestWindows();
                            }
                        }
                    }

                }


            }
            else
            {
                OpenQuestWindows();
            }
        }
        else
        {
            Debug.Log("Can't take Quest During NightTime");
            debugger.DebugPanels.SetActive(true);
            debugger.DebugText.text = "Can't take Quest During NightTime";
        }
    }


}
