using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VillageHeadInteraction : MonoBehaviour
{
    [SerializeField]
    UnityEvent[] m_villageHeadInteraction;

    public int VillageHeadInteractionUpdate_value;

    public void doVillageHeadInteraction()
    {
        m_villageHeadInteraction[VillageHeadInteractionUpdate_value].Invoke();
    }
    

}
