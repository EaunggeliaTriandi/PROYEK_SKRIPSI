using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Actions/Action")]
public class Action : ScriptableObject
{
    [SerializeField]
    private QuestGiver m_QG;
    public QuestGiver QG => m_QG;
}
