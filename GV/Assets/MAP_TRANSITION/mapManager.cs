using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[System.Serializable]
public class mapTransition
{
    public string mapName;
    public Transform[] MapTransform;
}

public class mapManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] maps;
    public PolygonCollider2D[] MapConfiners;
    public mapTransition[] mapTrans;
    

    public CinemachineConfiner confiner;


    //test only
    public void mainMap(int mapActive, int mapDeactive)
    {
        //Active
        maps[mapActive].SetActive(true);
        //Deactive
        maps[mapDeactive].SetActive(false);
    }



}
