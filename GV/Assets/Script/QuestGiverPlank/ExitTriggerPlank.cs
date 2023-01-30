using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTriggerPlank : MonoBehaviour
{
    public QuestGiver QG;
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        QG.questWindow.SetActive(false);
    }
}
