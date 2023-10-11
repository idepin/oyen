using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    [SerializeField] private InventoryUI inventoryUI;

    public void AddItem(Item item)
    {
        items.Add(item);
        inventoryUI.AddItemUI(item);
    }

    public bool HasItem(Item item)
    {
        if(items.Contains(item)) return true;
        return false;
    }

    public void RemoveItem(Item item)
    {
        if(items.Contains(item))
        {
            items.Remove(item);
        }
    }
}
