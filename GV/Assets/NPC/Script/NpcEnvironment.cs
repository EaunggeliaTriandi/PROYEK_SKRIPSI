using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcEnvironment
{
    private static NpcEnvironment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static NpcEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new NpcEnvironment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Npc1Checkpoint"));
            }

            return instance;
        }

    }
}
