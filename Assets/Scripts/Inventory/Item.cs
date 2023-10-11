using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemName", menuName = "Inventory/CreateItem", order = 1)]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
}
