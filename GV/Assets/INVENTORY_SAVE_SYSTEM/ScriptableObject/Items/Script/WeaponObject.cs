using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]
public class WeaponObject : ItemObject
{
    public float rangedAtkBonus;
    public float melleAtkBonus;

    public void Awake()
    {
        type = ItemType.Weapon;
    }
}
