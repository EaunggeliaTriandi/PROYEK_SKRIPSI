using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Weapon,
    Equipment,
    Quest
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject PrefabUI;
    public ItemType type;
    [TextArea(15,20)]
    public string description;

}
