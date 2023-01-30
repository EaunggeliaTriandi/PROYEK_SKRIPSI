using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            other.gameObject.SetActive(false);
            //if (other.gameObject.activeSelf == false)
            //{
            //    Debug.Log("object Item Inactive");
            //}
        }
    }
    //save sample 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.InventorySave();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            inventory.InventoryLoad();
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
