using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Map
{
    public string mapName;
    public GameObject[] MapBlockade;
}

public class GameBlockadeFlow : MonoBehaviour
{
    public int gameProgress;
    //public QuestCombinationManager QCM;
    public Map[] mapBlockade;
    
    // Start is called before the first frame update
    void Start()
    {
        
        //gameProgress = 0;
    }
    void Update()
    {
        //StatusProgress();   
    }

    //void StatusProgress()
    //{
    //    //Info (GameProgress/Map/Blocade/puzzleCombination)
    //    GameStatusProgress(0, 0, 0, "0000");
    //    GameStatusProgress(1, 0, 2, "1111");
    //    GameStatusProgress(2, 0, 3, "1111");

    //}

    public void GameStatusProgress(int GameProgress, int mapNumber, int blockadeNumber, string puzzle1Combination)
    {
        if (gameProgress == GameProgress)
        {
            mapBlockade[mapNumber].MapBlockade[blockadeNumber].SetActive(false);
            puzzleCombinationManager.combination = puzzle1Combination;

        }
    }

    
}
