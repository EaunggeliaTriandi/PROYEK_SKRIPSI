using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class poolItem
{
    public GameObject Prefab;
    public int amount;
}

public class pool : MonoBehaviour
{

    public static pool singleton;
    public List<poolItem> items;
    public List<GameObject> pooledItems;

    private void Awake()
    {
        singleton = this;
    }

    public GameObject Get(string tag)
    {
        for (int i = 0; i < pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }
        return null;
    }
    private void Start()
    {
        pooledItems = new List<GameObject>();
        foreach (poolItem item in items)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject obj = Instantiate(item.Prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }
    public GameObject GetList(string tag, int arrayedObject)
    {
        for (int i = 0; i< pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[arrayedObject];
            }
        }
        return null;
    }
}
