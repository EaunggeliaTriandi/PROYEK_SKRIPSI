using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int X_START;
    public int Y_START;
    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLUM;
    public int Y_SPACE_BETWEEN_ITEM;
    Dictionary<InventorySlot, GameObject> itemDisplayed = new Dictionary<InventorySlot, GameObject>();

    void Start()
    {
        CreateDisplay();
    }
    void Update()
    {
        UpdateDisplay();    
    }
    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemDisplayed.ContainsKey(inventory.Container[i]))
            {
                itemDisplayed[inventory.Container[i]].GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");

            }
            else
            {
                var obj = Instantiate(inventory.Container[i].item.PrefabUI, Vector2.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
                itemDisplayed.Add(inventory.Container[i], obj);
            }
        }
    }
    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.PrefabUI, Vector2.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");

            itemDisplayed.Add(inventory.Container[i], obj);
        }
    }
    public Vector2 GetPosition(int i)
    {
        return new Vector2(X_START + (X_SPACE_BETWEEN_ITEM *(i % NUMBER_OF_COLUM)), Y_START + (-Y_SPACE_BETWEEN_ITEM * (i / NUMBER_OF_COLUM)));
    }
}
