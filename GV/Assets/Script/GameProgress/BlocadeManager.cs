using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlocadeManager : MonoBehaviour
{
    public Quest quest;
    public VillageHeadInteraction headInteraction;
    public GameObject[] blocadeObject;
    public int BlocadeNumb;
    public string[] ColitionName;
    public int colitionNumb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ColitionName[colitionNumb])
        {
            if (quest.questTitle == ColitionName[0])
            {
                blocadeObject[BlocadeNumb].SetActive(false);
                if (colitionNumb == 0)
                {
                    headInteraction.VillageHeadInteractionUpdate_value=1;
                    ColitionName[colitionNumb] = "";
                    colitionNumb++;
                    BlocadeNumb++;



                }
                //if (colitionNumb >= 1 && BlocadeNumb >= 1)
                //{
                //    colitionNumb = 1;
                //    BlocadeNumb = 1;
                //}
                //else
                //{

                //    colitionNumb++;
                //    BlocadeNumb++;
                //}
            }
            if (quest.questTitle == ColitionName[1])
            {
                blocadeObject[BlocadeNumb].SetActive(false);
            }

        }
    }
}
