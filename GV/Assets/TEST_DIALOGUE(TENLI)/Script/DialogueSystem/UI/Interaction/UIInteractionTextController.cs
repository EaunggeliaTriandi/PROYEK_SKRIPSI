using UnityEngine;
using TMPro;

public class UIInteractionTextController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_Text;
    [SerializeField]
    private TextMeshProUGUI m_VillageHeadInteractionText;
    [SerializeField]
    private interactionInstigator m_WatchedInteractionInstigator;

    void Update()
    {
        //This is overkill it could be handled with events.
        m_Text.enabled = m_WatchedInteractionInstigator.enabled && m_WatchedInteractionInstigator.HasNearbyInteractables();
        m_VillageHeadInteractionText.enabled = m_WatchedInteractionInstigator.enabled && m_WatchedInteractionInstigator.HasNearbyVillageHeadInteraction();
    }
}
