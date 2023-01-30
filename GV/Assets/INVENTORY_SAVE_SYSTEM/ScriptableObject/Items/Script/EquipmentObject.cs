using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]

public class EquipmentObject : ItemObject
{
    public float rangedAtkBonus;
    public float melleAtkBonus;
    public float defenceBonus;
    public float maxHealthBonus;
    //public float heatResistance;
    //public float coldResistance;
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
