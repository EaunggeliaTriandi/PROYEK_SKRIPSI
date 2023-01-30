using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionInstigator : MonoBehaviour
{
    private List<Interactable> m_NearbyInteractables = new List<Interactable>();
    private List<VillageHeadInteraction> m_NearbyVillageHeadInteraction = new List<VillageHeadInteraction>();


    public bool HasNearbyInteractables()
    {
        return m_NearbyInteractables.Count != 0;
    }
    public bool HasNearbyVillageHeadInteraction()
    {
        return m_NearbyVillageHeadInteraction.Count != 0;
    }

    private void Update()
    {
        if (HasNearbyInteractables() && Input.GetButtonDown("Submit"))
        {
            //Ideally, we'd want to find the best possible interaction (ex: by distance & orientation).
            m_NearbyInteractables[0].DoInteraction();
            //Debug.Log("DialogStart");
        }
        if (HasNearbyVillageHeadInteraction() && Input.GetButtonDown("Submit"))
        {
            m_NearbyVillageHeadInteraction[0].doVillageHeadInteraction();
            //Ideally, we'd want to find the best possible interaction (ex: by distance & orientation).
            ////m_NearbyInteractables[0].DoInteraction();****** MAKE A NEW EVENT YOU STUPID BASTARD :> ******
            //Debug.Log("DialogStart");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        VillageHeadInteraction villageHeadInteraction = other.GetComponent<VillageHeadInteraction>();
        if (interactable != null)
        {
            m_NearbyInteractables.Add(interactable);
        }
        if (villageHeadInteraction != null)
        {
            m_NearbyVillageHeadInteraction.Add(villageHeadInteraction);
        }
        //Debug.Log("Enter");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        VillageHeadInteraction villageHeadInteraction = other.GetComponent<VillageHeadInteraction>();
        if (interactable != null)
        {
            m_NearbyInteractables.Remove(interactable);
        }
        if (villageHeadInteraction != null)
        {
            m_NearbyVillageHeadInteraction.Remove(villageHeadInteraction);
        }
        //Debug.Log("exit");
    }
    // Update is called once per frame
}
