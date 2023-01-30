using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTriggerTransition : MonoBehaviour
{
    public mapManager MM;
    [Space(20)]
    [Header("Map Active Controller")]
    public int mapON;
    public int mapOFF;

    [Space(20)]
    [Header("Select Map Confiner")]
    public int mapConfiner;

    [Space(20)]
    [Header("Select Map And Destination Position")]
    public int destinationMap;
    public int destinationPos;




    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "player")
        {
            MM.player.transform.position = MM.mapTrans[destinationMap].MapTransform[destinationPos].position;
            MM.mainMap(mapON, mapOFF);
            MM.confiner.m_BoundingShape2D = MM.MapConfiners[mapConfiner];
        }
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "player")
        {
            
        }
    }
    /// Event Interaction Caller
    
    public void toAbandonHouse()
    {
        MoveTrigger(6, 0, 6, 1, 6);
    }
    public void TriggerToOutsideAbandone()
    {
        MoveTrigger(1, 1, 1, 6, 1);
    }

    /// </summary>
    public void MoveTrigger(int destinationMap,int destinationPos, int MapOn, int MapOff, int MapConfiner)
    {
        MM.player.transform.position = MM.mapTrans[destinationMap].MapTransform[destinationPos].position;
        MM.mainMap(MapOn, MapOff);
        MM.confiner.m_BoundingShape2D =MM.MapConfiners[MapConfiner];
    }
}
